using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Supplier
{
    public class DStockOrderRequest
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getRequests(bool allRequests)
        {
            string selectQuery;
            DataSet dataSet = new DataSet();

            if (allRequests)
            {
                 selectQuery = "SELECT ReqID,InName,ReqQuantity,Description,RequestStatus," +
                    "DeliverOnDate,price FROM ingredientRequest";
            }
            else
            {
                selectQuery = "SELECT ReqID,InName, ReqQuantity, Description, RequestStatus, " +
                              "DeliverOnDate, price FROM ingredientRequest WHERE DeliverOnDate =" +
                              " CAST(GETDATE() AS DATE)";

            }

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(dataSet);

                    connection.closeConnection();
                    return dataSet;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int setPrice(Decimal netPrice, string reqId)
        {
            string updateQuery = @"
            UPDATE ingredientRequest 
            SET price = @netPrice,
            WHERE ReqID = @reqId;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@netPrice", netPrice);
                    cmd.Parameters.AddWithValue("@reqId", reqId);

                    int stat = cmd.ExecuteNonQuery();
                    connection.closeConnection();
                    return stat;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }


        public int setStatus(string reqId, string reqStat)
        {
            // Step 1: Retrieve the PaidOn date
            string paidOnQuery = "SELECT PaidOn FROM ingredientRequest WHERE ReqID = @reqId;";
            DateTime? paidOnDate = null;

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    // Get the PaidOn date
                    SqlCommand getPaidOnCmd = new SqlCommand(paidOnQuery, con);
                    getPaidOnCmd.Parameters.AddWithValue("@reqId", reqId);

                    object result = getPaidOnCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        paidOnDate = (DateTime?)result;
                    }

                    // Check and update the RequestStatus
                    if (paidOnDate == null) // No payment date found
                    {
                        if (reqStat == "Cash After Delivery" || reqStat == "Out for Delivery" || reqStat == "Delivered")
                        {
                            reqStat += " (Pending Payment)";
                        }
                    }

                    // Update the RequestStatus
                    string updateQuery = "UPDATE ingredientRequest SET RequestStatus = @reqStat WHERE ReqID = @reqId;";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@reqStat", reqStat);
                    updateCmd.Parameters.AddWithValue("@reqId", reqId);

                    int stat = updateCmd.ExecuteNonQuery();
                    connection.closeConnection();
                    return stat;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
