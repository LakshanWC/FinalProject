using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Model
{
    public class MPassResetRequests
    {
        MDBConnection myConnection = new MDBConnection();
        public DataSet getPassRequests() 
        {
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
    }
}
