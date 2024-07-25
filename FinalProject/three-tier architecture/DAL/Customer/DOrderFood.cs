using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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

        public int checkCard(string cardTelNo)
        {
            string selectQuery = "SELECT COUNT(*) FROM loyaltyCard WHERE telNo = @cardTelNo;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@cardTelNo", cardTelNo);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        return 1; // TelNo found
                    }
                    else
                    {
                        return 0; // TelNo not found
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return -1; // Exception occurred
            }
        }

        public bool generateUniqueId(string generatedId)
        {
            string selectQuery = "SELECT COUNT(*) FROM tblorder WHERE UniqeKey = @generatedId;"; 

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@generatedId", generatedId);

                    // Execute 
                    int count = (int)cmd.ExecuteScalar();

                    // If count > 0 ID already exists
                    return count > 0;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false; // Assume does not exist on error
            }
        }


        public string generateUniqueString()
        {
            string uniqueString;
            bool isThere;

            do
            {
                // Generate a new unique string
                uniqueString = Guid.NewGuid().ToString();

                // Check if the generated string exists
                isThere = generateUniqueId(uniqueString);

            } while (isThere); // Repeat if the unique string already exists

            return uniqueString;
        }

        private int getOid()
        {
            string selectQuery = "SELECT COUNT(*) FROM tblorder ; ";
            int rowCount;

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand( selectQuery, con);
                    rowCount = (int)cmd.ExecuteScalar();
                    connection.closeConnection();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return rowCount +1;
        }

        //add order

        public bool addOrder(int orderQuantity, DateTime createdDate, int orderStatus, string cNo,
                    string itemName, string uniqueKey, decimal totPrice)
        {
            int oid = getOid();
            DMDBConnection connDB = new DMDBConnection();

            string insertQuery = "INSERT INTO tblorder (Oid, Oquantity, Odate, OrderStatus, Cno, ItemName, UniqeKey, Price) " +
                "VALUES (@Oid, @Oquantity, @Odate, @OrderStatus, @Cno, @ItemName, @UniqeKey, @Price);";

            try
            {
                using (SqlConnection con = connDB.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@Oid", oid);
                    cmd.Parameters.AddWithValue("@Oquantity", orderQuantity);
                    cmd.Parameters.AddWithValue("@Odate", createdDate);
                    cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                    cmd.Parameters.AddWithValue("@Cno", cNo);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@UniqeKey", uniqueKey);
                    cmd.Parameters.AddWithValue("@Price", totPrice);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
