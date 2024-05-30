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
        public bool addEmployee(string Eid,string Ename,string Enic,string Eaddress,DateTime Edob,
            string Etel,string Eusername,string Epassword,double OtHours,double salary,int Etype)
        {
            SqlConnection con = myConnection.openConnection();
            string addEmpQuery = "INSERT INTO employee VALUES (@Eid,@Ename,@Enic,@Eaddress,@Edob" +
                ",@Etel,@Euername,@Epassword,@OtHours,@Etype,@salary);";

            SqlCommand com = new SqlCommand(addEmpQuery, con);
            com.Parameters.AddWithValue("@Eid", Eid);
            com.Parameters.AddWithValue("@Ename",Ename);
            com.Parameters.AddWithValue("@Enic",Enic);
            com.Parameters.AddWithValue("@Eaddress",Eaddress);
            com.Parameters.AddWithValue("@Edob", Edob);
            com.Parameters.AddWithValue("@Etel", Etel);
            com.Parameters.AddWithValue("@Eusername", Eusername);
            com.Parameters.AddWithValue("@Epassword",Epassword);
            com.Parameters.AddWithValue("@OtHours",OtHours);
            com.Parameters.AddWithValue("@salary",salary);

            com.ExecuteNonQuery();

            return true;
        }
    }
}
