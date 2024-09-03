using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Waiter
{
    public class DReservedTables
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getTables()
        {
            string selectQuery = "SELECT * FROM [Table] WHERE Tid !='non';";
            DataSet ds = new DataSet();

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

                    connection.closeConnection();
                    return ds;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int markTable(string tableName, string tblStat)
        {
            string updateQuery = "UPDATE [Table] SET status =@tblStat WHERE Tid =@tid;";
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@tblStat", tblStat);
                    cmd.Parameters.AddWithValue("@tid", tableName);
                    int stat  = cmd.ExecuteNonQuery();
 

                    connection.closeConnection();

                    return stat > 0 ? 1 : 0;
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
