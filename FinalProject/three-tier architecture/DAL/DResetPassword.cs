using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject.MVC.Model
{
    public class DResetPassword
    {
  

        public bool resetPassword(string username, string password)
        {
            DMDBConnection myConnection = new DMDBConnection();
            SqlConnection con = myConnection.openConnection();
            
                string userQuery = "SELECT COUNT(*) FROM employee WHERE Eusername = @username;";
                SqlCommand cmd = new SqlCommand(userQuery, con);
                cmd.Parameters.AddWithValue("@username", username);

                int count = (int)cmd.ExecuteScalar();

                if (count == 1)
                {

                    string requestQuery = "INSERT INTO userRequest (requestedUser, newpassword) VALUES (@username, @newpassword)";

                    SqlCommand mycmd = new SqlCommand(requestQuery, con);
                    mycmd.Parameters.AddWithValue("@username", username);
                    mycmd.Parameters.AddWithValue("@newpassword", password);

                    mycmd.ExecuteNonQuery();
                    

                    return true;
                }
                else
                {
                    return false;
                }
            
        }
        public bool requestExist(string username)
        {
            DMDBConnection myConn = new DMDBConnection();
            using (SqlConnection con = myConn.openConnection())
            {
                string userQuery = "SELECT COUNT(*) FROM userRequest WHERE requestedUser = @Eusername AND PasswordReset = 0;";
                using (SqlCommand cmd = new SqlCommand(userQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Eusername", username);

                    int count = (int)cmd.ExecuteScalar();
                    if( count == 1) return true;
                    else return false;
                }
            }
        }
    }
}
