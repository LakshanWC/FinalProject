using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.DAL.Supplier
{
    public class DStockOrderRequest
    {
        public static string inName;
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
            string updateQuery = "UPDATE ingredientRequest SET price = @netPrice WHERE ReqID = @reqId;";

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

                    if (paidOnDate != null ||  reqStat == "Delivered" ||  reqStat == "Delivered (Pending Payment)")
                    {
                        updateInventory(reqId);
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

        private DataSet getItemDetails(string id)
        {
            DMDBConnection coon = new DMDBConnection();

            string selectQuery = @"
                SELECT InName, ReqQuantity
                FROM ingredientRequest
                WHERE ReqID = @id
                AND RequestStatus NOT IN ('Delivered', 'Delivered (Pending Payment)');";

            DataSet dataSet = new DataSet();

            try
            {
                using (SqlConnection con = coon.openConnection())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                    adapter.Fill(dataSet);

                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        return dataSet;
                    }
                    else
                    {
                        Console.WriteLine("No item found with the provided ID or item is already delivered.");
                        return null;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }


        private void updateInventory(string id)
        {
            DMDBConnection connt = new DMDBConnection();
            DataSet data = new DataSet();
            data = getItemDetails(id);

            if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0)
            {
                Console.WriteLine("Item details could not be found or item is already delivered. Update operation aborted.");
                return;
            }

            DataTable tbl = data.Tables[0];
            DataRow row = tbl.Rows[0];
            string itemName = row["InName"].ToString();
            int reqQuantity = Convert.ToInt32(row["ReqQuantity"]);


            string updateQuery = "UPDATE [ingredient] SET Inquantity = Inquantity + @quantity WHERE InName = @name;";

            try
            {
                using (SqlConnection con = connt.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@quantity", reqQuantity);  // Use reqQuantity parameter
                    cmd.Parameters.AddWithValue("@name", itemName);  // Use itemName parameter

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Inventory updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows were updated. Please check the provided item name.");
                    }

                    connt.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
