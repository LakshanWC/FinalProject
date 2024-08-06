using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Customer
{
    public class DTrackDelivery
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getDeliveryOrders(string oId)
        {
            DataSet ds = new DataSet();
            string selectQuery =
            "SELECT OrderStatus, UniqeKey " +
            "FROM tblorder " +
            "WHERE tblorder.UniqeKey LIKE @oId + '%';";

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@oId",oId);
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

    }
}
