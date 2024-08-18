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
        DateTime paidDate = new DateTime();



        public DataSet getPaymentPending(bool allRequests)
        {
            string selectQuery;
            DataSet dataSet = new DataSet();

            selectQuery = "SELECT ReqID, InName, ReqQuantity, RequestStatus, " +
                              "DeliverOnDate, price FROM ingredientRequest " +
                              "WHERE PaidOn IS NULL OR PaidOn = ''";
            


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

        public int setAsPaid(string reqId,string price)
        {
            paidDate = DateTime.Now;
            decimal convetedPrice = Convert.ToDecimal(price);

            // Define queries
            string selectQuery = "SELECT RequestStatus FROM ingredientRequest WHERE ReqID = @reqId;";
            string updateQuery = "UPDATE ingredientRequest SET PaidOn = @paidDate, RequestStatus = @requestStatus WHERE ReqID = @reqId;";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    // Retrieve the current RequestStatus
                    SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                    selectCmd.Parameters.AddWithValue("@reqId", reqId);
                    string requestStatus = selectCmd.ExecuteScalar()?.ToString();

                    if (requestStatus == null)
                    {
                        // RequestStatus was not found
                        return -1;
                    }

                    // Modify the RequestStatus
                    requestStatus = RemoveBrackets(requestStatus);
                    if (requestStatus == "Payment Panding")
                    {
                        requestStatus = "Paid";
                    }
                    requestStatus += " (Paid)";

                    // Update the PaidOn date and RequestStatus
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@paidDate", paidDate);
                    updateCmd.Parameters.AddWithValue("@requestStatus", requestStatus);
                    updateCmd.Parameters.AddWithValue("@reqId", reqId);

                    int stat = updateCmd.ExecuteNonQuery();

                    //log the transaction if its succsesfull
                    if(stat > 0)
                    {
                        setTransactionLog(paidDate, convetedPrice, null);
                    }

                    connection.closeConnection();
                    return stat;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        // method to remove text inside brackets from the RequestStatus
        private string RemoveBrackets(string text)
        {
            int startIndex = text.IndexOf('(');
            if (startIndex >= 0)
            {
                int endIndex = text.IndexOf(')', startIndex);
                if (endIndex > startIndex)
                {
                    // Remove brackets and the text inside
                    text = text.Remove(startIndex, endIndex - startIndex + 1).Trim();
                }
            }
            return text;
        }


        public DataSet getAllPaid()
        {
            string selectQuery = "SELECT ReqID, InName, ReqQuantity, RequestStatus, " +
                                 "DeliverOnDate,price,PaidOn FROM ingredientRequest " +
                                 "WHERE PaidOn IS NOT NULL AND PaidOn != ''";
            DataSet data = new DataSet();


            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(data);

                    connection.closeConnection();
                    return data;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void setTransactionLog(DateTime logDateTime, decimal price,string orderName)
        {
            DMDBConnection connt = new DMDBConnection();

            // Break logDateTime into date and time 
            DateTime logDate = logDateTime.Date;
            TimeSpan logTime = new TimeSpan(logDateTime.Hour, logDateTime.Minute, logDateTime.Second);
            string formattedLogTime = logTime.ToString(@"hh\:mm\:ss");

            string insertQuery = @"
                INSERT INTO TransactionLog (OrderId, LogDate, LogTime, Amount)
                VALUES (@orderId, @logDate, @logTime, @amount);";

            if(orderName == null)
            {
                orderName = "Purchased Stocks";
            }

            try
            {
                using (SqlConnection con = connt.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@orderId", orderName); 
                    cmd.Parameters.AddWithValue("@logDate", logDate);
                    cmd.Parameters.AddWithValue("@logTime", formattedLogTime);
                    cmd.Parameters.AddWithValue("@amount", price);

                    cmd.ExecuteNonQuery();
                    connt.closeConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
