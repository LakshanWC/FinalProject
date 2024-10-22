using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.DAL.Supplier
{
    public class DInventory
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getInventoryItems()
        {
            DataSet inventoryItems = new DataSet();

            try
            {
                string selectQuery = "SELECT * FROM inventory;";

                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(inventoryItems);

                    return inventoryItems;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public int setInventoryItem(string inventoryItem, int quantity)
        {
            try
            {
                // check if an item with the same name already exists
                string checkQuery = "SELECT COUNT(*) FROM inventory WHERE itemName = @itemName;";

                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@itemName", inventoryItem);

                    int existingItemsCount = (int)checkCmd.ExecuteScalar();

                    if (existingItemsCount > 0)
                    {
                        MessageBox.Show("An item with this name already exists. Please change the name.", "Duplicate Item Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;  // No insertion
                    }

                    // If no duplicate exists, proceed with the insertion
                    string insertQuery = "INSERT INTO inventory (itemName, iQuantity) VALUES (@itemName, @iQuantity);";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@itemName", inventoryItem);
                    cmd.Parameters.AddWithValue("@iQuantity", quantity);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return 1;  // Item successfully inserted
                    }
                    else
                    {
                        return 0;  // No rows affected
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;  // Exception 
            }
        }

        public DataSet getSelectedItem(string name)
        {
            DataSet items = new DataSet();

            try
            {
                string selectQuery = "SELECT * FROM inventory WHERE itemName = @name;";

                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@name",name);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(items);

                    return items;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public int updateInventoryItem(string inventoryItem, int quantity,string newName)
        {
            try
            {
                string updateQuery = "UPDATE inventory SET itemName = @newName, iQuantity = @iQuantity WHERE itemName = @id;";

                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@iQuantity", quantity);
                    cmd.Parameters.AddWithValue("@newName", newName);
                    cmd.Parameters.AddWithValue("@id",inventoryItem); 

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return 1;  // Item successfully updated
                    }
                    else
                    {
                        return 0;  // No rows affected 
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;  // Exception 
            }
        }

        public int deleteInventoryItem(string itemName)
        {
            try
            {
                string deleteQuery = "DELETE FROM inventory WHERE itemName = @itemName;";

                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@itemName", itemName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return 1;  // Item successfully deleted
                    }
                    else
                    {
                        return 0;  // No rows affected (item not found)
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;  // Exception occurred
            }
        }

        
        //dont really chagne any in here
        public double getPercentage(string itemName)
        {
            string query;

            if (itemName == "All")
            {
                query = "SELECT iQuantity FROM inventory"; // Use iQuantity from inventory table
            }
            else
            {
                query = "SELECT iQuantity FROM inventory WHERE itemName = @itemName"; // Filter by itemName
            }

            // Maximum quantity per item is 100.
            int maxQuantityPerItem = 100;
            int totalQuantity = 0;
            int itemCount = 0;

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand command = new SqlCommand(query, con);

                    if (itemName != "All")
                    {
                        command.Parameters.AddWithValue("@itemName", itemName); // Use itemName parameter
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int quantity = reader.GetInt32(0);
                            totalQuantity += quantity; // Sum up the quantities
                            itemCount++; // Count the number of items
                        }
                    }
                }

                // Calculating the overall percentage
                if (itemCount > 0)
                {
                    int maxPossibleTotalQuantity = itemCount * maxQuantityPerItem;
                    double overallScore = (double)totalQuantity / maxPossibleTotalQuantity * 100;
                    return overallScore; // Return percentage score
                }
                else
                {
                    return 0; // No items found
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // Return -1 for exceptions
            }
        }


    }
}
