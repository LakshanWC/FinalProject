using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.three_tier_architecture.PL.Delivery_Team;

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
            DMDBConnection conn = new DMDBConnection();

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
                using(SqlConnection con = conn.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@deliveryStat", deliveryStat);
                    cmd.Parameters.AddWithValue("@oid", oid);
                    cmd.Parameters.AddWithValue("@name", itemName);

                    int result = cmd.ExecuteNonQuery();
                    conn.closeConnection();

                    return result;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public bool setDeliveryLog(string userName, string oid, string itemName, string deliveryStatus, bool isNormalOrder)
        {
            string query = "";
            DateTime deliveryTime = DateTime.Now;
            string orderType = isNormalOrder ? "Normal" : "Special";

            if (deliveryStatus == "On the Way")
            {
                query = "INSERT INTO delivery (delivedBy, orderId, itemName, DeliveryStarted, orderType) " +
                        "VALUES(@delivedBy, @orderId, @itemName, @deliveryStart, @orderType);";
            }
            else if (deliveryStatus == "Delivered")
            {
                query = "UPDATE delivery " +
                        "SET delivedBy = @delivedBy, " +
                        "itemName = @itemName, " +
                        "DeliveryEnded = @deliveryEnd, " +
                        "orderType = @orderType " +
                        "WHERE orderId = @orderId;";
            }

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@delivedBy", userName);
                        cmd.Parameters.AddWithValue("@orderId", oid);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@deliveryStart", deliveryTime);
                        cmd.Parameters.AddWithValue("@deliveryEnd", deliveryTime);
                        cmd.Parameters.AddWithValue("@orderType", orderType);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.closeConnection();

                        // Return true if at least one row was affected
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    

    public DataSet getAcceptedDelivery()
        {
            DataSet result = new DataSet();

            try
            {
                string selectQuery = "SELECT delivedBy, orderId, itemName, DeliveryStarted, orderType " +
                                     "FROM delivery WHERE delivedBy = @uid " +
                                     "AND DeliveryEnded IS NULL;";


                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@uid", DeliveryTeamHome.userNameDelivery);

                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(result);

                    connection.closeConnection();
                    return result;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
