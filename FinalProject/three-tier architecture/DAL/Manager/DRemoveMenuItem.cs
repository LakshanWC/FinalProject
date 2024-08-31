using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Manager
{
    public class DRemoveMenuItem
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getMenuItemsData(string itemName)
        {
            string selectQuery = "SELECT itemName,itemCalories,itemPrice,itemImageNo FROM Items WHERE itemName =@itName ;";
            DataSet ds = new DataSet();

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@itName",itemName);
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
        public DataSet getItemNames()
        {
            string selectQuery = "SELECT itemName FROM Items ;";
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(ds);

                    connection.closeConnection();
                    return ds;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool deleteMenuItem(string itemName)
        {
            string selectQuery = "Delete FROM Items WHERE itemName =@itName ;";
            DataSet ds = new DataSet();
            DMDBConnection conn = new DMDBConnection();

            try
            {
                using (SqlConnection con = conn.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@itName", itemName);
                    
                    int effectedRow = cmd.ExecuteNonQuery();

                    conn.closeConnection();
                    if (effectedRow > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
