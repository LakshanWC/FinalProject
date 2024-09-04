using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FinalProject.MVC.Model
{
    public class DManagerHome_All
    {
        DMDBConnection myConnection = new DMDBConnection();
        
        public int getPasswordResetRequests()
        {

            SqlConnection con = myConnection.openConnection();
            string getResquestQuery = "SELECT Count(*) FROM userRequest WHERE PasswordReset = 0 ;";
            SqlCommand cmd = new SqlCommand(getResquestQuery, con);

            int count = (int)cmd.ExecuteScalar();
            myConnection.closeConnection();

            return count;
        }

        public int noOfEmployees()
        {
            string selectQuery = "SELECT COUNT(*) FROM employee;";
            try
            {
                using (SqlConnection con = myConnection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    int count = (int)cmd.ExecuteScalar();  

                    return count;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // Return -1 in case of an error
            }
            finally
            {
                myConnection.closeConnection(); // close connection
            }
        }

        public decimal getIncome()
        {
            DMDBConnection connection = new DMDBConnection();

            // Get the current month and year
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            // Query for tblorder
            string selectQuery = "SELECT SUM(Price) FROM tblorder WHERE MONTH(Odate) = @currentMonth AND YEAR(Odate) = @currentYear;";

            // Query for specialOrderRequest
            string secondQuery = "SELECT SUM(Price) FROM specialOrderRequest WHERE MONTH(SpOrderDate) = @currentMonth AND YEAR(SpOrderDate) = @currentYear;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    // Execute first query
                    SqlCommand cmd1 = new SqlCommand(selectQuery, con);
                    cmd1.Parameters.AddWithValue("@currentMonth", currentMonth);
                    cmd1.Parameters.AddWithValue("@currentYear", currentYear);
                    object result1 = cmd1.ExecuteScalar();
                    decimal incomeFromOrders = result1 != DBNull.Value ? Convert.ToDecimal(result1) : 0;

                    // Execute second query
                    SqlCommand cmd2 = new SqlCommand(secondQuery, con);
                    cmd2.Parameters.AddWithValue("@currentMonth", currentMonth);
                    cmd2.Parameters.AddWithValue("@currentYear", currentYear);
                    object result2 = cmd2.ExecuteScalar();
                    decimal incomeFromSpecialOrders = result2 != DBNull.Value ? Convert.ToDecimal(result2) : 0;


                    // Return the total income from both queries
                    return incomeFromOrders + incomeFromSpecialOrders;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // Return -1 in case of an error
            }
            finally
            {
                connection.closeConnection(); // Ensure connection is closed
            }
        }

        public int getCustomerSatis()
        {
            string query = @"
            SELECT 
            (CAST(COUNT(CASE WHEN [Rrate] >= 4 THEN 1 END) AS DECIMAL) / COUNT(*)) * 100 
            AS CustomerSatisfactionPercentage
            FROM 
            [restaurantdb].[dbo].[review];";

            try
            {
                using (SqlConnection con = myConnection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 0; // Return 0 if no data found
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // Return -1 in case of an error
            }
            finally
            {
                myConnection.closeConnection(); // Ensure connection is closed
            }
        }

        public DataSet getEvents()
        {
            DMDBConnection connt = new DMDBConnection();

            // SQL query to select events happening today with Estatus of 0 or 1
            string selectQuery = @"
                SELECT Ename, EstartTime, Estatus 
                FROM event 
                WHERE Estatus IN (0, 1) 
                AND CONVERT(date, EstartDate) = CONVERT(date, GETDATE());";

            try
            {
                using (SqlConnection con = connt.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connt.closeConnection();
            }
        }

    }
}
