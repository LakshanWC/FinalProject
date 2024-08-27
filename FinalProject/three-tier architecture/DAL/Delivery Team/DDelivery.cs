using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Delivery_Team
{
    public class DDelivery
    {    
        DMDBConnection connection = new DMDBConnection();

        public DataSet getOrders()
        {
            DataSet orders = new DataSet();
            // Updated query to include conditions for OrderStatus and Odate
            string selectQuery = "SELECT OrderStatus, Oquantity, Odate, Cno, ItemName, UniqeKey, DeliveryStatus " +
                                 "FROM tblorder " +
                                 "WHERE " +
                                 "OrderStatus IN ('Express Delivery','Standard Delivery') " +
                                 "AND DeliveryStatus = 'Ready For Delivery';";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(orders);

                    connection.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return orders;
        }

        public DataSet getSpecialOrders()
        {
            DataSet orders = new DataSet();
            string selectQuery = "SELECT SORid, quantity, itemName, orderStat, DeliveryStat " +
                      "FROM specialOrderRequest " +
                      "WHERE " +
                      "orderStat IN ('Express Delivery', 'Standard Delivery') " +
                      "AND DeliveryStat = 'Ready For Delivery';";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(orders);

                    connection.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return orders;
        }

        public int updateDeliveryStatus(string oid,string itemName,bool orderType,string deliveryStat)
        {
            string updateQuery;

            if (orderType)
            {
                //normal order
                updateQuery = "UPDATE tblorder SET DeliveryStatus = @deliveryStat WHERE UniqeKey = @oid AND ItemName =@name;";
            }
            else
            {
                //special order
                updateQuery = "UPDATE specialOrderRequest SET DeliveryStat = @deliveryStat WHERE SORid = @oid itemName =@name;";
            }

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@deliveryStat", deliveryStat);
                    cmd.Parameters.AddWithValue("@oid", oid);
                    cmd.Parameters.AddWithValue("@name", itemName);

                    int result = cmd.ExecuteNonQuery();
                    connection.closeConnection();

                    return result;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
