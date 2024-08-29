using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.three_tier_architecture.PL.Delivery_Team;
using System.Xml.Linq;
using FinalProject.MVC;
using System.Windows.Forms;
using CrystalDecisions.Web.HtmlReportRender;

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
                                 "OrderStatus IN ('Express Delivery','Standard Delivery','COD') " +
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
                      "orderStat IN ('Express Delivery', 'Standard Delivery','COD') " +
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

                    setDeliveryLog(DeliveryTeamHome.userNameDelivery, oid, itemName, deliveryStat, orderType);

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
                if (addToLogIfCOD(oid, itemName, isNormalOrder) == true)
                {
                    MessageBox.Show("Payment not received. Select 'Delivered (Payment Received)' after payment.","Warning"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    query = "UPDATE delivery " +
                            "SET delivedBy = @delivedBy, " +
                            "itemName = @itemName, " +
                            "DeliveryEnded = @deliveryEnd, " +
                            "orderType = @orderType " +
                            "WHERE orderId = @orderId;";
                }

            }
            else if(deliveryStatus =="Delivered(Payment Received)")
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

                        if(deliveryStatus =="Delivered(Payment Received)" && rowsAffected >0)
                        {
                            //run the log is only this is succseful
                            setTransactionLog(oid, isNormalOrder, itemName);
                        }

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

        private void setTransactionLog(string oid, bool isNormalOrder, string itemName)
        {
            DMDBConnection coont = new DMDBConnection();
            //string selectQuery = "SELECT COUNT(*) FROM TransactionLog;";
            string selectPrice;
            decimal price;

            // Determine the price query based on the order type
            if (isNormalOrder)
            {
                selectPrice = "SELECT Price FROM tblorder WHERE UniqeKey = @key AND ItemName = @name;";
            }
            else
            {
                selectPrice = "SELECT Price FROM specialOrderRequest WHERE SORid = @key AND itemName = @name;";
            }

            using (SqlConnection con = coont.openConnection())
            {
                SqlCommand dmc = new SqlCommand(selectPrice, con);
                dmc.Parameters.AddWithValue("@key", oid);
                dmc.Parameters.AddWithValue("@name", itemName);

                // Execute & retrieve the price
                price = (decimal)dmc.ExecuteScalar();
                coont.closeConnection();
            }

            string insertQuery = "INSERT INTO TransactionLog(OrderId, LogDate, LogTime, Amount) " +
                                 "VALUES(@orderId, @logDate, @logTime, @amount)";

            DateTime logDate = DateTime.Now.Date;
            TimeSpan logTime = DateTime.Now.TimeOfDay;

            

            try
            {
                using (SqlConnection conn = connection.openConnection())
                {

                    //add the log
                    SqlCommand cmdd = new SqlCommand(insertQuery, conn);
                    cmdd.Parameters.AddWithValue("@orderId", "Order Delivery");  
                    cmdd.Parameters.AddWithValue("@logDate", logDate);
                    cmdd.Parameters.AddWithValue("@logTime", logTime);
                    cmdd.Parameters.AddWithValue("@amount", price);

                    cmdd.ExecuteNonQuery();
                    connection.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int updateDeliveryTemp(string oid, string itemName, bool orderType, string deliveryStat)
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
                using (SqlConnection con = conn.openConnection())
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
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }



        private bool addToLogIfCOD(string itemId,string itName,bool itNormalOrder)
        {
            DMDBConnection conn = new DMDBConnection();

            string selectQuery ="";

            if (itNormalOrder)
            {
                selectQuery ="SELECT OrderStatus FROM tblorder WHERE ItemName = @name AND UniqeKey = @key ;";
            }
            else
            {
                selectQuery = "SELECT orderStat FROM specialOrderRequest WHERE itemName = @name AND SORid = @key;";
            }

            try
            {
                using(SqlConnection con = conn.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@name", itName);
                    cmd.Parameters.AddWithValue("@key", itemId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        connection.closeConnection();
                        return true;
                    }
                    else
                    {
                        connection.closeConnection();
                        return false;
                    }
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine (ex.Message);
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
