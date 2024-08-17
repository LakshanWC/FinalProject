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
                RequestStatus = CASE 
                WHEN RequestStatus = 'Payment Before Delivery' THEN 'Pending Payment'
                WHEN RequestStatus = 'Requested' THEN 'Pending Payment'
                ELSE RequestStatus
                END 
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


        public int setPrice(string reqId,string reqStat)
        {
            string updateQuery = "UPDATE ingredientRequest SET RequestStatus = @reqStat WHERE ReqID = @reqId;";
            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@reqStat", reqStat);
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



    }
}
