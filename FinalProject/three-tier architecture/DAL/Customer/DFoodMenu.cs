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
    public class DFoodMenu
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getMenuItems()
        {
            DataSet result = new DataSet();

            try
            {
                string sqlQuery = "SELECT * FROM Items;";

                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd); 
                    dap.Fill(result); // Fill DataSet 
                }
            }
            catch (SqlException e)
            {
                // Handle exception 
                Console.WriteLine("SQL Exception: " + e.Message);
            }

            return result;
        }

    }
}
