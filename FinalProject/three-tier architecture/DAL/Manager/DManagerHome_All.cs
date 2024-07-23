using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FinalProject.MVC.Model
{
    public class DManagerHome_All
    {
        DMDBConnection myConnection = new DMDBConnection();
        
        public int getPasswordResetRequests()
        {

            SqlConnection con = myConnection.openConnection();
            string getResquestQuery = "SELECT Count(*) FROM userRequest WHERE PasswordReset = 0 ;";
            SqlCommand cmd = new SqlCommand(getResquestQuery, con);

            int count = (int)cmd.ExecuteScalar();
            myConnection.closeConnection();

            return count;
        }

    }
}
