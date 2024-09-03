using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Waiter
{
    public class DCustomerRequests
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getRequestData(string type)
        {
            string selectQuery = "SELECT requestType,requestDetails,tableNo,requestBy " +
                "FROM AssistantRequests WHERE requestType =@type;";
            DataSet ds = new DataSet();

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@type", type);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

                    connection.closeConnection();
                    return ds;
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
