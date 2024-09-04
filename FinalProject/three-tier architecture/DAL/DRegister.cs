using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL
{
    public class DRegister
    {
        DMDBConnection connection = new DMDBConnection();

        public string genarateCustomerId()
        {
            string selectQuery = "SELECT Count(*) FROM customer ;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    int count = (int)cmd.ExecuteScalar() +1;

                    string id = "C0000"+Convert.ToString(count);

                    return count > 0 ? id : null;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public int addCustomer(string id, string name, string nic, string address, DateTime dob,
                string email, string telNo, string userName, string pass)
        {
            string insertQuery = @"
                 INSERT INTO [restaurantdb].[dbo].[customer] 
                 ([Cid], [Cname], [Cnic], [Caddress], [Cdob], [Cemail], [Ctel], [Cusername], [Cpassword])
                 VALUES 
                 (@Cid, @Cname, @Cnic, @Caddress, @Cdob, @Cemail, @Ctel, @Cusername, @Cpassword);";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@Cid", id);
                    cmd.Parameters.AddWithValue("@Cname", name);
                    cmd.Parameters.AddWithValue("@Cnic", nic);
                    cmd.Parameters.AddWithValue("@Caddress", address);
                    cmd.Parameters.AddWithValue("@Cdob", dob);
                    cmd.Parameters.AddWithValue("@Cemail", email);
                    cmd.Parameters.AddWithValue("@Ctel", telNo);
                    cmd.Parameters.AddWithValue("@Cusername", userName);
                    cmd.Parameters.AddWithValue("@Cpassword", pass);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // Indicates an error occurred
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public int addEmployee(string id, string name, string nic, string address, DateTime dob,
            string telNo, string userName, string pass,int empType)
        {
            string insertQuery = @"
        INSERT INTO [restaurantdb].[dbo].[employee] 
        ([Eid], [Ename], [Enic], [Eaddress], [Edob], [Etel], [Eusername], [Epassword],[Etype],[accountStatus])
        VALUES 
        (@Eid, @Ename, @Enic, @Eaddress, @Edob, @Etel, @Eusername, @Epassword,@Etype,@accountStatus);";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@Eid", id);
                    cmd.Parameters.AddWithValue("@Ename", name);
                    cmd.Parameters.AddWithValue("@Enic", nic);
                    cmd.Parameters.AddWithValue("@Eaddress", address);
                    cmd.Parameters.AddWithValue("@Edob", dob);
                    cmd.Parameters.AddWithValue("@Etel", telNo);
                    cmd.Parameters.AddWithValue("@Eusername", userName);
                    cmd.Parameters.AddWithValue("@Epassword", pass);
                    cmd.Parameters.AddWithValue("@Etype", empType);
                    cmd.Parameters.AddWithValue("@accountStatus", 1);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // Indicates an error occurred
            }
            finally
            {
                connection.closeConnection();
            }
        }
    }
}

