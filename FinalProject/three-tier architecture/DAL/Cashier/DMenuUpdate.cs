using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Cashier
{
    public class DMenuUpdate
    {
        DMDBConnection connection = new DMDBConnection();

        public int updateMenuItem(string itemName,string price,string calories)
        {
            try
            {
                string updateQuery = "UPDATE items SET itemPrice = @price , itemCalories = @itemCalories WHERE itemName = @name;";

                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@itemCalories", calories);
                    cmd.Parameters.AddWithValue("@name", itemName);

                    int stat =  cmd.ExecuteNonQuery();
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
