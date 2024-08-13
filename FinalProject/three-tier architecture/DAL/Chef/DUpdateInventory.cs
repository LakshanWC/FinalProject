using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Chef
{
    public class DUpdateInventory
    {
        DMDBConnection connection = new DMDBConnection();

        public int updateStockDetails(string stockName, int quantity, string stockStat)
        {
            string updateQuery = "UPDATE ingredient SET Inquantity = @quantity, inStatus = @stockStat " +
                                 "WHERE InName = @oldName;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@stockStat", stockStat);
                        cmd.Parameters.AddWithValue("@oldName", stockName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        connection.closeConnection();
                        return rowsAffected;
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
