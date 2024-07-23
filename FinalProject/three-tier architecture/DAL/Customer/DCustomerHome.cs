using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Customer
{
    public class DCustomerHome
    {
        DMDBConnection connection = new DMDBConnection();
        string userId = string.Empty;

        public string getUserId(string userName) 
        {
            string sqlQuery = "SELECT Cid FROM customer WHERE Cusername = @userName;";
            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    userId = cmd.ExecuteScalar().ToString();

                    connection.closeConnection();
                }
            } 
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return userId;
        }
    }
}
