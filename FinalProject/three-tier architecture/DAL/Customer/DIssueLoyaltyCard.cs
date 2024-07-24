using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Customer
{
    public class DIssueLoyaltyCard
    {
        DMDBConnection connection = new DMDBConnection();

        public int activeCard(string telNo)
        {
            string checkQuery = "SELECT cardStatus FROM loyaltyCard WHERE telNo = @telNo;";
            string updateQuery = "UPDATE loyaltyCard SET cardStatus = 1 WHERE telNo = @telNo;";
            int result;

            try
            {
                using (SqlConnection con = connection.openConnection())
                {
                    // Check the current status of the card
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@telNo", telNo);
                        object statusObj = checkCmd.ExecuteScalar();

                        if (statusObj == null)
                        {
                            // No record found
                            return 0;
                        }

                        int cardStatus = Convert.ToInt32(statusObj);

                        if (cardStatus == 1)
                        {
                            // Card is already active
                            return 2;
                        }
                    }

                    // Update the card status
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@telNo", telNo);
                        result = updateCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            // Update succeeded
                            return 1;
                        }
                        else
                        {
                            // Update failed
                            return -1;
                        }
                    }
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
