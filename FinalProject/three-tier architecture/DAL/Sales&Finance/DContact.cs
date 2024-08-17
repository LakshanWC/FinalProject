using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Sales_Finance
{
    public class DContact
    {
        DMDBConnection connection = new DMDBConnection();

        private int getReqId()
        {
            DMDBConnection conn = new DMDBConnection();

            int reqId = 0;
            string query = "SELECT COUNT(*) FROM ingredientRequest";
            try
            {
                using(SqlConnection con = conn.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    reqId = (int)cmd.ExecuteScalar();

                    conn.closeConnection();
                    return reqId +1;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int setRequest(string inName, int reqQuantity, DateTime requestDate, string description,
        string requestStatus, DateTime deliveryOn)
        {
            int reqId = getReqId();
            string insertQuery = "INSERT INTO ingredientRequest " +
                "(ReqID, InName, ReqQuantity, RequestDate, Description, RequestStatus, DeliverOnDate) " +
                "VALUES (@reqId, @inName, @reqQuantity, @reqDate, @description, @reqStatus, @DeliverOn)";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@reqId", reqId);
                    cmd.Parameters.AddWithValue("@inName", inName);
                    cmd.Parameters.AddWithValue("@reqQuantity", reqQuantity);
                    cmd.Parameters.AddWithValue("@reqDate", requestDate);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@reqStatus", requestStatus);
                    cmd.Parameters.AddWithValue("@DeliverOn", deliveryOn);

                    int result = cmd.ExecuteNonQuery();

                    connection.closeConnection();
                    return result; 
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; 
            }
        }
    }
}
