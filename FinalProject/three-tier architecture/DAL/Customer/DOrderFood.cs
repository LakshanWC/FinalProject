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
    public class DOrderFood
    {
        DMDBConnection connection = new DMDBConnection();
        
        public DataSet getItemData(string itemId)
        {
            DataSet itemData = new DataSet();
            string selectQuery = "SELECT * FROM items WHERE itemID = @itemId ;";

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(itemData);

                    connection.closeConnection();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return itemData;
        }
    }
}
