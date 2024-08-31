using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Sales_Finance
{
    public class DAddOt
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getUserNames()
        {
            string selectQuery = "SELECT Eusername FROM employee WHERE Eusername != 'admin' AND Eusername !='emp' ;";
            DataSet dataSet = new DataSet();

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(dataSet);

                    return dataSet;
                    
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool setOT(decimal otHours,string userName)
        {
            string updateQuery = "UPDATE employee SET OtHours = @otHours WHERE Eusername = @userName ;";

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@otHours", otHours);
                    cmd.Parameters.AddWithValue("@userName", userName);

                    int stat = cmd.ExecuteNonQuery();
                    return stat > 0 ? true : false;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public DataSet getUserDetails(string userName)
        {
            string selectQuery = "SELECT Eusername,Etype,OtHours FROM employee WHERE Eusername = @name;";
            DataSet dataSet = new DataSet();

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@name",userName);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(dataSet);

                    return dataSet;

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
