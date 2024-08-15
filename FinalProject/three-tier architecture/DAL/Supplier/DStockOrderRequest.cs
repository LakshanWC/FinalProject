using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Supplier
{
    public class DStockOrderRequest
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getRequests(bool allRequests)
        {
            string selectQuery;
            DataSet dataSet = new DataSet();

            if (allRequests)
            {
                 selectQuery = "SELECT InName,ReqQuantity,Description,RequestStatus," +
                    "DeliverOnDate,price FROM ingredientRequest";
            }
            else
            {
                selectQuery = "SELECT InName, ReqQuantity, Description, RequestStatus, " +
                              "DeliverOnDate, price FROM ingredientRequest WHERE DeliverOnDate =" +
                              " CAST(GETDATE() AS DATE)";

            }

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(dataSet);

                    connection.closeConnection();
                    return dataSet;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
