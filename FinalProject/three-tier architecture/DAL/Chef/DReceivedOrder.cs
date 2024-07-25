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
        OrderStatus 0 == ordered
        OrderStatus 1 == standedDelivery
        OrderStatus 2 == ExpressDelivery
        */

        public DataSet getOrders()
        {
            DataSet orders = new DataSet();
            string selectQuery = "SELECT Oid,Oquantity, Odate, Cno, ItemName, UniqeKey FROM tblorder " +
                "WHERE OrderStatus = 1 OR OrderStatus = 2 OR OrderStatus = 0;";

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(orders);

                    connection.closeConnection();
                }

            }catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return orders;
        }
    }
}
