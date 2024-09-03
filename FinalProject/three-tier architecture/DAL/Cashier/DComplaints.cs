using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Cashier
{
    public class DComplaints
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getAllComplaints()
        {
            DataSet ds = new DataSet();
            string select = "SELECT * FROM AssistantRequests WHERE requestType ='Complaint';";

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

                    connection.closeConnection();
                    return ds;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
