using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Chef
{
    public class DUpdateShowcase
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet checkShowCase(string item)
        {
            string selectQuery = "SELECT * FROM showCase WHERE ItemName = @itemName;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@itemName", item);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds); // Fill the DataSet with the result of the query

                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                // If the dataset contains tables and rows
                                return ds;
                            }
                            else
                            {
                                // If no rows were found
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }


        public DataSet getAvailableItems(bool defaultSearch,string itName)
        {
            // Base query
            string selectQuery = "SELECT itemName, itemImageNo FROM Items";

            // if defaultSearch is false
            if (!defaultSearch)
            {
                selectQuery += " WHERE itemName =@itName"; 
            }

            DataSet result = new DataSet();

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);

                    // Add parameter if needed
                    if (!defaultSearch && !string.IsNullOrEmpty(itName))
                    {
                        cmd.Parameters.AddWithValue("@itName", itName); 
                    }

                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(result);

                    return result;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }


        public int setShowCaseItem(string itemName, int imageNo, int quantity)
        {
            string selectQuery = "SELECT COUNT(*) FROM showCase WHERE ItemName = @itemName;";
            string insertQuery = "INSERT INTO showCase (ItemName, Quantity, ImageNo) VALUES (@itemName, @quantity, @imageNo);";
            string updateQuery = "UPDATE showCase SET Quantity = @quantity, ImageNo = @imageNo WHERE ItemName = @itemName;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    // Check if the item exists 
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@itemName", itemName);

                        int count = (int)cmd.ExecuteScalar(); 

                        int rowsAffected = 0;

                        if (count > 0)
                        {
                            // If the item exists, update it
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@itemName", itemName);
                                updateCmd.Parameters.AddWithValue("@imageNo", imageNo);
                                updateCmd.Parameters.AddWithValue("@quantity", quantity);

                                rowsAffected = updateCmd.ExecuteNonQuery(); 
                            }
                        }
                        else
                        {
                            // If the item does not exist, insert it
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                            {
                                insertCmd.Parameters.AddWithValue("@itemName", itemName);
                                insertCmd.Parameters.AddWithValue("@quantity", quantity);
                                insertCmd.Parameters.AddWithValue("@imageNo", imageNo);

                                rowsAffected = insertCmd.ExecuteNonQuery(); 
                            }
                        }

                        // Return 1 OR return 0 
                        return rowsAffected > 0 ? 1 : 0;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            finally
            {
                connection.closeConnection();
            }
        }
    }
}
