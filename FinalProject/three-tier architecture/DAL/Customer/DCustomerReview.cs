using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.MVC.Model;

namespace FinalProject.three_tier_architecture.DAL.Customer
{
    public class DCustomerReview
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getItemNames()
        {
            DataSet results = new DataSet();
            string sqlQuery = "SELECT itemName FROM items;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(results);
                    connection.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return results;
        }

        public int addReview(string cusId, string itemName, int reviewScore, string comment)
        {
            // Check if the review already exists
            string checkQuery = "SELECT COUNT(*) FROM review WHERE Cid = @cusId AND itemName = @itemName";

            string insertQuery = "INSERT INTO review (RComment, Rrate, Cid, itemName) VALUES " +
                "(@comment, @reviewScore, @cusId, @itemName);";
            int result;

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    // Check for existing review
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@cusId", cusId);
                        checkCmd.Parameters.AddWithValue("@itemName", itemName);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Review already exists
                            return 2;
                        }
                    }

                    // Insert new review
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@comment", comment);
                        insertCmd.Parameters.AddWithValue("@reviewScore", reviewScore);
                        insertCmd.Parameters.AddWithValue("@cusId", cusId);
                        insertCmd.Parameters.AddWithValue("@itemName", itemName);

                        result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            // Insert succeeded
                            return 1;
                        }
                        else
                        {
                            // Insert failed
                            return 0;
                        }
                    }
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
