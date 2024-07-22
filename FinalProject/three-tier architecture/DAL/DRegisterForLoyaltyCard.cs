using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.DAL
{
    public class DRegisterForLoyaltyCard
    {
        DMDBConnection connection = new DMDBConnection();

        public int addLoyaltyCard(string customerId, string cardHolderName, string telNo, DateTime createdDate)
        {
            string checkQuery = "SELECT COUNT(*) FROM loyaltyCard WHERE telNo = @telNo";
            string insertQuery = "INSERT INTO loyaltyCard (cardHolderName, telNo, issuedDate, cardStatus, cid) " +
                                 "VALUES (@cardHolderName, @telNo, @issuedDate, @cardStatus, @cid)";

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    // check if the record already exists
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@telNo", telNo);
                        int recordCount = (int)checkCmd.ExecuteScalar();

                        if (recordCount > 0)
                        {
                            
                            return 2; // Record exists
                        }
                    }

                    // Record does not exist, proceed with the insert
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@cardHolderName", cardHolderName);
                        insertCmd.Parameters.AddWithValue("@telNo", telNo);
                        insertCmd.Parameters.AddWithValue("@issuedDate", createdDate);
                        insertCmd.Parameters.AddWithValue("@cardStatus", 0); 
                        insertCmd.Parameters.AddWithValue("@cid", customerId);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        connection.closeConnection();

                        if (rowsAffected > 0)
                        {
                            return 1; // Success
                        }
                        else
                        {
                            return 0; // No rows affected
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return -1; // Exception occurred
            }
        }

    }
}
