using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.MVC.Model
{
    public class DPassResetRequests
    {
        

        public DataSet getPassRequests() 
        {
            DMDBConnection myConnection = new DMDBConnection();
            try
            {
                SqlConnection con = myConnection.openConnection();

                string getPassQuery = "SELECT Eid,PasswordReset,requestedUser FROM userRequest;";
                SqlCommand comm = new SqlCommand(getPassQuery, con);

                SqlDataAdapter dap = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                return ds;
            }
            finally
            {
                
                myConnection.closeConnection();
            }                    
        }

        public bool setNewPassword(string eid)
        {
            DMDBConnection myConnection = new DMDBConnection();
            try
            {
                using (SqlConnection con = myConnection.openConnection())
                {
                    // Define the queries
                    string selectQuery = "SELECT newpassword FROM userRequest WHERE Eid = @eid;";
                    string updateQuery = "UPDATE employee SET Epassword = @pass WHERE Eid = @eid;";
                    string secondUpdateQ = "UPDATE userRequest SET PasswordReset = 1 WHERE Eid = @eid;";

                    // Retrieve the new password
                    SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                    selectCommand.Parameters.AddWithValue("@eid", eid);
                    string newPassword = (string)selectCommand.ExecuteScalar();

                    if (string.IsNullOrEmpty(newPassword))
                    {
                        // New password not found
                        return false;
                    }

                    // Update the employee password
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@pass", newPassword);
                    updateCommand.Parameters.AddWithValue("@eid", eid);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Update the user request status
                        SqlCommand secondUpdateCommand = new SqlCommand(secondUpdateQ, con);
                        secondUpdateCommand.Parameters.AddWithValue("@eid", eid);
                        secondUpdateCommand.ExecuteNonQuery();
                    }

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                myConnection.closeConnection();
            }
        }
    }

}
