 using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.DAL.Customer
{
    public class DTrackDelivery
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getDeliveryOrders(string oId, bool isNormalOrder)
        {
            DataSet ds = new DataSet();
            string selectQuery;

            if (isNormalOrder)
            {
                // Query for normal orders
                selectQuery = "SELECT OrderStatus, UniqeKey " +
                              "FROM tblorder " +
                              "WHERE tblorder.UniqeKey LIKE @oId + '%';";
            }
            else
            {
                // Query for special orders
                selectQuery = "SELECT DeliveryStat AS OrderStatus, SORid AS UniqeKey " +
                              "FROM specialOrderRequest " +
                              "WHERE specialOrderRequest.SORid LIKE @oId + '%';";
            }

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@oId", oId);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

                    connection.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return ds;
        }

        public string getOrderDeliverStat(string oId, bool isNormalOrder)
        {
            string status = null;

            try
            {
                string selectQuery;

                if (isNormalOrder)
                {
                    selectQuery = "SELECT DeliveryStatus FROM tblorder WHERE UniqeKey = @oid;";
                }
                else
                {
                    selectQuery = "SELECT DeliveryStat FROM specialOrderRequest WHERE SORid = @oid;";
                }

                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@oid", oId);

                    // If the result set is empty, it returns null.
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        status = result.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine (ex.Message);
                return null;
            }

            return status;
        }
    }
}

