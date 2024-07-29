using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Chef
{
    public class DReceivedOrder
    {
        DMDBConnection connection = new DMDBConnection();

        /*
        OrderStatus  == TakeOut
        OrderStatus  == Dine in
        OrderStatus  == standedDelivery
        OrderStatus  == ExpressDelivery
        */

        public DataSet getOrders()
        {
            DataSet orders = new DataSet();
            // Updated query to include conditions for OrderStatus and Odate
            string selectQuery = "SELECT OrderStatus, Oquantity, Odate, Cno, ItemName, UniqeKey ,Tid FROM tblorder " +
                                 "WHERE CAST(Odate AS DATE) = CAST(GETDATE() AS DATE) " +
                                 "AND OrderStatus IN ('Express Delivery', 'Take Out', 'Dine in', 'Standard Delivery')";

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
            string selectQuery = "SELECT SORid, quantity, extraItem1, extraItem2, extraItem3, SORdetails, itemName, orderStat " +
                                 "FROM specialOrderRequest " +
                                 "WHERE CAST(SpOrderDate AS DATE) = CAST(GETDATE() AS DATE)" + "" +
                                 "AND orderStat IN ('Express Delivery', 'Take Out', 'Dine in', 'Standard Delivery');";
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
    }
}
