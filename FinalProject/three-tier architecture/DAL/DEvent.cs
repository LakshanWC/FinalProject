using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.DAL
{
    public class DEvent
    {
        DMDBConnection connection = new DMDBConnection();

        public int addNewEvent(string eventName, string eventOrganizer,int eventType,int eventStatus 
            ,string eventDescription, string startDate, string endDate, string startTime ,string endTime)
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
    }
}
