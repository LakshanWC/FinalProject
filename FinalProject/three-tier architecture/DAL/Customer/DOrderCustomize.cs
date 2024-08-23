using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Customer
{
    public class DOrderCustomize
    {
        DMDBConnection connDB = new DMDBConnection();

        //add order

        public int addSpecialOrder(int orderQuantity, DateTime createdDate, string orderStatus,
              string itemName, string uniqueKey, decimal totPrice, string extraItem1, string extraItem2,
              string extraItem3, string SORdetails, string deliverStat)
        {

            //query 
            string insertQuery = "INSERT INTO specialOrderRequest (SORid, quantity, extraItem1, extraItem2, extraItem3, SORdetails, itemName, Price, orderStat, SpOrderDate,DeliveryStat) " +
                                 "VALUES (@SORid, @quantity, @extraItem1, @extraItem2, @extraItem3, @SORdetails, @itemName, @Price, @orderStat, @SpOrderDate, @DeliveryStat);";

            try
            {
                using (SqlConnection con = connDB.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(insertQuery, con);

                    // parameter  and values 
                    cmd.Parameters.AddWithValue("@SORid", uniqueKey); 
                    cmd.Parameters.AddWithValue("@quantity", orderQuantity);
                    cmd.Parameters.AddWithValue("@extraItem1", extraItem1);
                    cmd.Parameters.AddWithValue("@extraItem2", extraItem2);
                    cmd.Parameters.AddWithValue("@extraItem3", extraItem3);
                    cmd.Parameters.AddWithValue("@SORdetails", SORdetails);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@Price", totPrice);
                    cmd.Parameters.AddWithValue("@orderStat", orderStatus);
                    cmd.Parameters.AddWithValue("@SpOrderDate", createdDate);
                    cmd.Parameters.AddWithValue("@DeliveryStat",deliverStat);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Return 1 if insert was successful
                    return rowsAffected > 0 ? 1 : 0;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return -1; // Return -1 to indicate an error
            }
        }


    }
}
