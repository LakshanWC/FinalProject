using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.DAL
{
    public class DAddItem
    {
        DMDBConnection connection = new DMDBConnection();

        public int addItem(string itemName, double itemPrice, int itemType, int itemCalories, string itemDescription, int imageNo)
        {
            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    string query = "INSERT INTO items (itemName, itemPrice, itemImageNo, itemDescription, itemType, itemCalories) " +
                                   "VALUES (@itemName, @itemPrice, @itemImageNo, @itemDescription, @itemType, @itemCalories);";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@itemPrice", itemPrice);
                    cmd.Parameters.AddWithValue("@itemImageNo", imageNo);
                    cmd.Parameters.AddWithValue("@itemDescription", itemDescription);
                    cmd.Parameters.AddWithValue("@itemType", itemType);
                    cmd.Parameters.AddWithValue("@itemCalories", itemCalories);

                    int count = cmd.ExecuteNonQuery();
                    connection.closeConnection();

                    if (count > 0) { return 1; }
                    else { return 0; }
                }
            } catch (SqlException e){
                Console.WriteLine(e.Message);
                return -1;

            }
        }
        public int getItemId()
        {
            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) FROM items;";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        int results = (int)cmd.ExecuteScalar();
                        return results + 1;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                return -1;
            }
        }

    }
}
