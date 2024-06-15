using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL
{
    public class DUpdateEmployee
    {
        public bool updateEmpDetails(string eID,string eName,string nicNo,string eAddress, 
            DateTime dob, string eTel ,string eUserName,string ePassword,int oTHours,int salary, int accountStatus)
        {
            DMDBConnection connection = new DMDBConnection();
            SqlConnection con =  connection.openConnection();

            try
            {
                string query = "UPDATE employee SET Ename = @eName, Enic = @nicNo, Eaddress = @eAddress," +
                    " Edob = @dob,Etel = @eTel, Eusername = @eUserName,Epassword = @ePassword, OtHours = @oTHours," +
                    " salary = @salary, accountStatus = @accountStatus WHERE Eid = @eID;";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@eID", eID);
                cmd.Parameters.AddWithValue("@eName", eName);
                cmd.Parameters.AddWithValue("@nicNo", nicNo);
                cmd.Parameters.AddWithValue("@accountStatus",accountStatus);
                cmd.Parameters.AddWithValue("@eAddress", eAddress);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@eTel", eTel);
                cmd.Parameters.AddWithValue("@eUserName", eUserName);
                cmd.Parameters.AddWithValue("@ePassword", ePassword);
                cmd.Parameters.AddWithValue("@oTHours", oTHours);
                cmd.Parameters.AddWithValue("@salary", salary);

                int rowsAffected = cmd.ExecuteNonQuery();
                connection.closeConnection();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            { 
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

    }
}
