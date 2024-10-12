using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Chef
{
    public class DUpdateShowcase
    {
        DMDBConnection connection = new DMDBConnection();
        
        public DataSet getItems()
        {
            string selectAll = "SELECT itemName FROM Items;";
            DataSet ds = new DataSet();

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectAll, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

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
                connection.closeConnection();
            }
        }

        public DataSet getAllDetails(string name)
        {
            string selectQuery = "SELECT itemImageNo,showcaseItem FROM Items WHERE itemName =@name;";
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

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
                connection.closeConnection();
            }
        }

        public int updateItems(string name,int quantity)
        {
            string updateQuery = "UPDATE Items SET showcaseItem = @quantity WHERE itemName = @name;";
            int stat = 0;

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@quantity",quantity);
                    
                    stat = cmd.ExecuteNonQuery();

                    return stat > 0 ? 1 : 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                connection.closeConnection();
            }
        }
    }
}
