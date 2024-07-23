using FinalProject.MVC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL
{
    public class DRemoveEmployee
    {
        DMDBConnection connection = new DMDBConnection();

        public int removeEmployee(string eid, int deleteType)
        {
            
            int count = 0;
            string query;

            if (deleteType == 0)
            {
                query = "DELETE FROM employee WHERE Eid = @eid;";
            }
            else if (deleteType == 1)
            {
                query = "UPDATE employee SET accountStatus = 0 WHERE Eid = @eid;";
            }
            else
            {
                return 0;
            }

            try
            {
                using (SqlConnection sqlConnection = connection.openConnection())
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@eid", eid);
                    count = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }

            return count > 0 ? 1 : 0;
        }

        public DataSet getEmployeeDetails(string eid)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT * FROM employee WHERE Eid = @eid ;";
                using (SqlConnection conn = connection.openConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eid",eid);
                        using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                        {
                            dap.Fill(ds);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return ds;
        
        }

    }
}
