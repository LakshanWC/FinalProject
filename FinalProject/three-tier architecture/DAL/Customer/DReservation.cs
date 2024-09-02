using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Customer
{
    public class DReservation
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getAvailableTables(int noOfSeats)
        {
            DataSet result = new DataSet();
            string selectQuery = "SELECT Tid FROM [restaurantdb].[dbo].[Table] WHERE noOfSeats = @noOfSeats AND status = 'free';";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@noOfSeats", noOfSeats);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(result);

                    return result;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //update tables table
        public bool updateTblStat(string Tid,DateTime reservDate, DateTime reservTime)
        {
            DMDBConnection conne = new DMDBConnection();

            if (Tid == "non")
            {
                return false;
            }
            else
            {
                try
                {
                    string updatQuery = "UPDATE [Table] " +
                        "SET status = 'Resivered' ,ReserveDate =@reservDate ,ReserveTime = @resevTime " +
                        "WHERE Tid =@Tid;";

                    using (SqlConnection conn = conne.openConnection())
                    {
                        SqlCommand cmmd = new SqlCommand(updatQuery, conn);
                        cmmd.Parameters.AddWithValue("@Tid", Tid);
                        cmmd.Parameters.AddWithValue("@reservDate", reservDate);
                        cmmd.Parameters.AddWithValue("@resevTime", reservTime);
                        cmmd.ExecuteNonQuery();

                        conne.closeConnection();
                        return true;
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }
    }
}
