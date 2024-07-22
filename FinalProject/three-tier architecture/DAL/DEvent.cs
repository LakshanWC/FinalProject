using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Web.UI.WebControls;
using System.Runtime.InteropServices.ComTypes;

namespace FinalProject.three_tier_architecture.DAL
{
    public class DEvent
    {
        DMDBConnection connection = new DMDBConnection();

        public int addNewEvent(string eventName, string eventOrganizer, int eventType, int eventStatus
            , string eventDescription, string startDate, string endDate, string startTime, string endTime)
        {

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    string sqlQuery = "INSERT INTO event (Ename, EstartDate, EendDate, EstartTime, EendTime, " +
                                      "Edescription, Eorganizer, Etype, Estatus) " +
                                      "VALUES (@eventName, @startDate, @endDate, @startTime, @endTime, " +
                                      "@eventDescription, @eventOrganizer, @eventType, @eventStatus);";

                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    cmd.Parameters.AddWithValue("@eventName", eventName);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@startTime", startTime);
                    cmd.Parameters.AddWithValue("@endTime", endTime);
                    cmd.Parameters.AddWithValue("@eventDescription", eventDescription);
                    cmd.Parameters.AddWithValue("@eventOrganizer", eventOrganizer);
                    cmd.Parameters.AddWithValue("@eventType", eventType);
                    cmd.Parameters.AddWithValue("@eventStatus", eventStatus);

                    int result = cmd.ExecuteNonQuery();

                    connection.closeConnection();

                    if (result == 1) { return 1; }
                    else return 0;

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }

        }
        public int GetNextEventId()
        {
            string sqlQuery = "SELECT TOP 1 Eid FROM event ORDER BY Eid DESC;";
            int nextEid = -1;

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int lastEid))
                        {
                            nextEid = lastEid + 1;
                        }
                        else
                        {
                            // If no rows exist, start with an initial value
                            nextEid = 1; // Or any initial value you want
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return nextEid;
        }


        public DataSet getEventNames(bool isloadById)
        {
            DateTime todaysDate = DateTime.Now.Date; // Use .Date to ensure no time part is included

            DataSet dataSet = new DataSet();
            string sqlQuery;

            if (isloadById)
            {
                sqlQuery = "SELECT Eid FROM event WHERE EstartDate >= @todaysDate";
            }
            else
            {
                sqlQuery = "SELECT Ename FROM event WHERE EstartDate >= @todaysDate";
            }

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        // Use SqlDbType.Date to specify the parameter type
                        cmd.Parameters.Add(new SqlParameter("@todaysDate", SqlDbType.Date) { Value = todaysDate });

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataSet);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                return null;
            }

            return dataSet;
        }


        public DataSet getAllEvents(bool isloadById)
        {
            DataSet dataSet = new DataSet();
            string sqlQuery;

            if (isloadById)
            {
                sqlQuery = "SELECT Eid FROM event";
            }
            else
            {
                sqlQuery = "SELECT Ename FROM event";
            }

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataSet);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                return null;
            }

            return dataSet;
        }

        public int updateEvent(int eventId, string eventName, string eventOrganizer, int eventType, int eventStatus
            , string eventDescription, string startDate, string endDate, string startTime, string endTime)
        {
            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    string sqlQuery = "UPDATE event SET " +
                                       "Ename = @eventName, " +
                                       "EstartDate = @startDate, " +
                                       "EendDate = @endDate, " +
                                       "EstartTime = @startTime, " +
                                       "EendTime = @endTime, " +
                                       "Edescription = @eventDescription, " +
                                       "Eorganizer = @eventOrganizer, " +
                                       "Etype = @eventType, " +
                                       "Estatus = @eventStatus " +
                                       "WHERE Eid = @eventId;";

                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@eventId", eventId);
                    cmd.Parameters.AddWithValue("@eventName", eventName);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@startTime", startTime);
                    cmd.Parameters.AddWithValue("@endTime", endTime);
                    cmd.Parameters.AddWithValue("@eventDescription", eventDescription);
                    cmd.Parameters.AddWithValue("@eventOrganizer", eventOrganizer);
                    cmd.Parameters.AddWithValue("@eventType", eventType);
                    cmd.Parameters.AddWithValue("@eventStatus", eventStatus);

                    int result = cmd.ExecuteNonQuery();

                    connection.closeConnection();

                    return result; // Return the number of affected rows
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // Return -1 to indicate an error occurred
            }
        }

        public DataSet getEventDetails(string eventBy, bool byPrimeryKey)
        {
            string sqlQuery;
            DataSet results = new DataSet();

            if (byPrimeryKey)
            {
                sqlQuery = "SELECT * FROM event WHERE Eid = @eid;";
            }
            else
            {
                sqlQuery = "SELECT * FROM event WHERE Ename = @ename;";
            }

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    if (byPrimeryKey)
                    {
                        int converted = Convert.ToInt32(eventBy);
                        cmd.Parameters.AddWithValue("@eid", converted);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ename", eventBy);
                    }

                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(results);

                    return results;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public bool deleteEvent(string eventBy, bool byPrimeryKey) 
        {
            string sqlQuery;

            if (byPrimeryKey)
            {
                sqlQuery = "DELETE FROM event WHERE Eid = @eid;";
            }
            else
            {
                sqlQuery = "DELETE FROM event WHERE Ename = @ename;";
            }

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    if (byPrimeryKey)
                    {
                        int conveted = Convert.ToInt32(eventBy);
                        cmd.Parameters.AddWithValue("@eid", conveted);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ename", eventBy);
                    }
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; ;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}