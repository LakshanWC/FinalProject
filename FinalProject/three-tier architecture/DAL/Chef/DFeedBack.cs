using FinalProject.MVC;
using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace FinalProject.three_tier_architecture.DAL.Chef
{
    public class DFeedBack
    {
        public void setFeedBack(string feedbackType, string feedBack)
        {
            DMDBConnection connection = new DMDBConnection();

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    string selectQuery = "SELECT * FROM Feedback WHERE feedbackDate = CAST(GETDATE() AS DATE);";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, con);

                    // Execute the scalar query to get the count of today's feedback
                    object result = selectCmd.ExecuteScalar();

                    // Safely check for null before casting to int
                    int stat = result != null ? (int)result : 0; // If null, set stat to 0

                    if (stat == 0) // If no feedback exists for today
                    {
                        // Insert new feedback if none exists for today's date
                        string insertQuery = "INSERT INTO Feedback (feedbackType, feedback, feedbackDate) " +
                                             "VALUES (@feedbackType, @feedback, CAST(GETDATE() AS DATE));";

                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@feedbackType", feedbackType);
                        insertCmd.Parameters.AddWithValue("@feedback", feedBack);

                        int res = insertCmd.ExecuteNonQuery(); // Execute the insert query

                        if (res > 0)
                        {
                            Console.WriteLine("Feedback inserted successfully.");
                            TostMessage messSucc = new TostMessage("Feedback inserted successfully.", "Successful", 3, 3);
                            messSucc.Show();
                        }
                        else if (res == 0)
                        {
                            TostMessage messFail = new TostMessage("Feedback insert Faild.", "Faild", 1, 2);
                            messFail.Show();
                        }
                    }
                    else
                    {
                        // Update the existing feedback
                        string updateQuery = "UPDATE Feedback SET feedback = @feedback WHERE feedbackDate = CAST(GETDATE() AS DATE);";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@feedback", feedBack);

                        int updateResult = updateCmd.ExecuteNonQuery(); // Execute the update query

                        if (updateResult > 0)
                        {
                            Console.WriteLine("Feedback updated successfully.");
                            TostMessage messSucc = new TostMessage("Feedback updated successfully.", "Successful", 3, 3);
                            messSucc.Show();
                        }
                        else
                        {
                            TostMessage messFail = new TostMessage("Feedback update failed.", "Failed", 1, 2);
                            messFail.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TostMessage messFail = new TostMessage("UnExpected Error.", "Error", 2, 2);
                messFail.Show();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.closeConnection();
            }

        }

        public DataSet getFeedBack()
        {
            DMDBConnection cont = new DMDBConnection();
            DataSet dataSet = new DataSet();

            try
            {
                using (SqlConnection con = cont.openConnection())
                {
                    string selectQuery = "SELECT feedbackType,feedback FROM Feedback WHERE feedbackDate = CAST(GETDATE() AS DATE);";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cont.closeConnection();
            }

            return dataSet;
        }
    }
}