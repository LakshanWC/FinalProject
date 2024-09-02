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
    public class DRequestAssistant
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getTblNames()
        {
            DataSet ds = new DataSet();
            string selectQuery = "SELECT Tid FROM [Table];";

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
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

        public int addRequest(string reqType,string tblNo,string reqestBy,string reqestDetails)
        {
            string insertQuery = "INSERT INTO AssistantRequests (requestType, requestDetails, tableNo, requestBy) " +
                                 "VALUES (@reqType, @reqDetails, @tblNo, @reqBy);";

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@reqType", reqType);
                    cmd.Parameters.AddWithValue("@reqDetails", reqestDetails);
                    cmd.Parameters.AddWithValue("@tblNo", tblNo);
                    cmd.Parameters.AddWithValue("@reqBy", reqestBy);

                    int result = cmd.ExecuteNonQuery();
                    connection.closeConnection();

                    return result > 0 ? 1 : 0;
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
