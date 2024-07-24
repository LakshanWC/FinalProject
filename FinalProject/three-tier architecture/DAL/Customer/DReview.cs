using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Customer
{
    public class DReview
    {
        DMDBConnection connection = new DMDBConnection();

        public string getItemName(string itemId)
        {
            string itemName = "empty";
            string sqlQuery = "SELECT itemName FROM items WHERE itemID = @itemId ;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    itemName = cmd.ExecuteNonQuery().ToString();
                    connection.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return itemName = "exception";
            }
            return itemName;
        }

        public DataSet getReviewData(string itemName)
        {
            DataSet dataSet = new DataSet();
            string sqlQuery = "SELECT * FROM review WHERE itemName = @itemName;";
            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand (sqlQuery, con);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(dataSet);

                    connection.closeConnection();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return dataSet;
        }

        public DataSet getAllReviewItemNames()
        {
            DataSet results = new DataSet();
            string sqlQuery = "SELECT itemName FROM review;";

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

        public int getReviewCount(string itemName)
        {
            string sqlQuery = "SELECT COUNT(*) FROM review WHERE itemName = @itemName;";
            int rows = 0;
            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    rows = (int)cmd.ExecuteScalar();
                    connection.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return rows;
        }
    }
}
