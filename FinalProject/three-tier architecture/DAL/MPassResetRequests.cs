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
    public class MPassResetRequests
    {
        

        public DataSet getPassRequests() 
        {
            MDBConnection myConnection = new MDBConnection();
            try
            {
                SqlConnection con = myConnection.openConnection();

                string getPassQuery = "SELECT URid,PasswordReset,requestedUser FROM userRequest;";
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

        public int updateSelectedRows(List<int> selectedRowIds)
        {
            MPassResetRequests myPass = new MPassResetRequests();
            MDBConnection myConnection = new MDBConnection();
            int affectedRowCount = 0;
            SqlConnection con = myConnection.openConnection();



            foreach (int id in selectedRowIds)
            {
                // Update database command
                string updateQuery = "UPDATE userRequest SET PasswordReset = 1 WHERE URid = @ID";

                using (SqlCommand command = new SqlCommand(updateQuery, con))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    affectedRowCount += command.ExecuteNonQuery();
                }
                myConnection.closeConnection();
            }
            return affectedRowCount;
        }
        private bool setNewPassword()
        {
            MDBConnection myConnection = new MDBConnection();
            using (SqlConnection con = myConnection.openConnection())
            {
                string setNewPassQuery = @"
            UPDATE employee 
            SET Epassword = (SELECT newpassword FROM userRequest UR WHERE Eusername = UR.requestedUser AND PasswordReset = 1)
            WHERE EXISTS (SELECT 1 FROM userRequest UR WHERE Eusername = UR.requestedUser AND PasswordReset = 1);";

                using (SqlCommand comm = new SqlCommand(setNewPassQuery, con))
                {
                    comm.ExecuteNonQuery();
                }
            }
            myConnection.closeConnection();
            return true;
        }

    }

}
