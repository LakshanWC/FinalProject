using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL
{
    public class DGeneralReports
    {
        public DataSet getAttendentDetails()
        {
            DMDBConnection connection = new DMDBConnection();
            SqlConnection con = connection.openConnection();
            string query = "SELECT * FROM attendance ;";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            connection.closeConnection();

            return ds;
        }


    }
}
