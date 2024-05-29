using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Model
{
    public class MAddEmployee
    {
        MDBConnection myConnection = new MDBConnection();
        private string newEno = "";

        public string getNewEid()
        {
            
            SqlConnection con = myConnection.openConnection();
            string getLastEnoQuery = "SELECT TOP 1 Eid FROM employee ORDER BY Eid DESC";
            SqlCommand com = new SqlCommand(getLastEnoQuery, con);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
           
            string lastEno = dr["Eid"].ToString();
            string numberOnly = lastEno.Substring(1);
            int nextId = int.Parse(numberOnly)+1;
            newEno = "e"+ nextId.ToString("D6");

            myConnection.closeConnection();
            return newEno;
        }
    }
}
