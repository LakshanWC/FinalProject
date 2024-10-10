using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Cashier
{
    public class DShowCase
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getShowCaseItemNames()
        {
            string select = "SELECT * FROM ShowCase ;";
            DataSet ds = new DataSet();

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

                    return ds;
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public DataSet getMenuItemPriceAndCalories(string name)
        {
            string select = "SELECT itemPrice ,itemCalories FROM Items WHERE itemName = @name;";
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(select, con);
                    cmd.Parameters.AddWithValue("@name",name);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

                    return ds;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                connection.closeConnection();
            }
        }
    }
}
