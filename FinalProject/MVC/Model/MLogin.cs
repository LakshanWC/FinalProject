using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Model
{
    public class MLogin
    {
        

        public int Login(string username, string password)
        {
            MDBConnection myConnection = new MDBConnection();
            SqlConnection con = myConnection.openConnection();

            // Check for employee login
            string empLoginQuery = "SELECT ISNULL(Etype, 0) FROM employee WHERE Eusername = @username AND EPassword = @password;";
            SqlCommand cmd = new SqlCommand(empLoginQuery, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            object empResult = cmd.ExecuteScalar();
            if (empResult != null && empResult != DBNull.Value)
            {
                int empType = Convert.ToInt32(empResult);
                if (empType != 0)
                {
                    return empType; // Employee login successful, empType contains the value of Etype
                }
            }

            // If employee login failed, check for customer login
            string cusLoginQuery = "SELECT COUNT(*) FROM customer WHERE Cusername = @username AND CPassword = @password;";
            SqlCommand cusCmd = new SqlCommand(cusLoginQuery, con);
            cusCmd.Parameters.AddWithValue("@username", username);
            cusCmd.Parameters.AddWithValue("@password", password);

            object cusResult = cusCmd.ExecuteScalar();
            if (cusResult != null && cusResult != DBNull.Value)
            {
                int cusCount = Convert.ToInt32(cusResult);
                if (cusCount == 1)
                {
                    myConnection.closeConnection();
                    return 7; // Customer login successful, return 7    
                }
            }

            // If neither employee nor customer login was successful
            myConnection.closeConnection();
            return 0;
        }

        public void markAttendant(string username)
        {
            MDBConnection myConnection = new MDBConnection();

            using (SqlConnection con = myConnection.openConnection())
            {
                string attendantQuery = "SELECT Eid FROM employee WHERE Eusername = @username;";
                using (SqlCommand cmd = new SqlCommand(attendantQuery, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        dap.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            // Employee ID found
                            var employeeId = ds.Tables[0].Rows[0]["Eid"];

                            // Check if the employee has already been marked present today
                            string attendanceCheckQuery = "SELECT COUNT(*) FROM attendance WHERE Eno = @Eno AND CONVERT(DATE, todays) = CONVERT(DATE, GETDATE());";
                            using (SqlCommand checkCmd = new SqlCommand(attendanceCheckQuery, con))
                            {
                                checkCmd.Parameters.AddWithValue("@Eno", employeeId);

                                int count = (int)checkCmd.ExecuteScalar();

                                if (count == 0)
                                {
                                    // Employee has not been marked present today, so mark attendance
                                    string markAttendant = "INSERT INTO attendance (Eno, todays) VALUES (@Eno, @todaysDate);";
                                    using (SqlCommand comm = new SqlCommand(markAttendant, con))
                                    {
                                        comm.Parameters.AddWithValue("@Eno", employeeId);
                                        comm.Parameters.AddWithValue("@todaysDate", DateTime.Now);

                                        comm.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Employee has already been marked present today
                                    Console.WriteLine("Employee has already been marked present today.");
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
