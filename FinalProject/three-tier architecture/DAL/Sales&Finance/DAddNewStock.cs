using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Sales_Finance
{
    public class DAddNewStock
    {
        DMDBConnection connection = new DMDBConnection();

        public int addnewStock(string stockName, int quantity)
        {
            DMDBConnection connect = new DMDBConnection();

            string iId = getId();
            string checkQuery = "SELECT COUNT(*) FROM ingredient WHERE InName = @stockName;";
            string insertQuery = "INSERT INTO ingredient (Inid, InName, Inquantity) VALUES (@id, @stockName, @quantity);";

            try
            {
                using (SqlConnection con = connect.openConnection())
                {
                    // Check if the name exists
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@stockName", stockName);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        return 2; // name already exists
                    }

                    // Insert the new stock if it does not exist
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@id", iId);
                    insertCmd.Parameters.AddWithValue("@stockName", stockName);
                    insertCmd.Parameters.AddWithValue("@quantity", quantity);
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public string getId()
        {
            string newId = "";
            string selectQuery = "SELECT COUNT(*) FROM ingredient";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    int rowCount = (int)cmd.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        newId = "001";
                    }
                    else
                    {
                        string maxInidQuery = "SELECT MAX(CAST(Inid AS INT)) FROM ingredient";
                        cmd.CommandText = maxInidQuery;
                        int lastInid = (int)cmd.ExecuteScalar();
                        newId = (lastInid + 1).ToString("D3"); // Format number to add some zeros
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            connection.closeConnection();
            return newId;
        }

        public DataSet getStockNames()
        {
            string selectQuery = "SELECT InName FROM ingredient";
            DataSet data = new DataSet();

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(data);
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return data;
        }

    }
}
