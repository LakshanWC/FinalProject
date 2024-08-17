using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Sales_Finance
{
    public class DTransaction
    {
        DMDBConnection connection = new DMDBConnection();

        public DataSet getPaymentPending(bool allRequests)
        {
            string selectQuery;
            DataSet dataSet = new DataSet();

            if (allRequests)
            {
                selectQuery = "SELECT ReqID, InName, ReqQuantity, RequestStatus, " +
                              "DeliverOnDate, price FROM ingredientRequest " +
                              "WHERE RequestStatus IN ('Delivered (Pending Payment)', 'Pending Payment', 'Cash After Delivery (Pending Payment)')";
            }
            else
            {
                selectQuery = "SELECT ReqID, InName, ReqQuantity, RequestStatus, " +
                              "DeliverOnDate, price FROM ingredientRequest " +
                              "WHERE DeliverOnDate = CAST(GETDATE() AS DATE) " +
                              "AND RequestStatus IN ('Delivered (Pending Payment)', 'Pending Payment', 'Cash After Delivery (Pending Payment)')";
            }

            try
            {
                using (SqlConnection con = connection.openConnection())
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
