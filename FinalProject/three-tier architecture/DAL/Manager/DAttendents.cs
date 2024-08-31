using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Manager
{
    public class DAttendents
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getAttendents(string filterType)
        {
            string selectQuery = "";
            DataSet results = new DataSet();

            if(filterType == "All")
            {
                selectQuery = "SELECT * FROM attendance ;";
            }
            else if(filterType =="Monthly")
            {
                selectQuery = "SELECT * FROM attendance WHERE FORMAT([todays], 'yyyyMM') = FORMAT(GETDATE(), 'yyyyMM');";
            }
            else
            {
                selectQuery = "SELECT * FROM attendance WHERE YEAR([todays]) = YEAR(GETDATE());";
            }

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(results);

                    connection.closeConnection();
                    return results;
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
