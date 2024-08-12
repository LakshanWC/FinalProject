using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.DAL.Sales_Finance
{
    public class DStockUi
    {
        DMDBConnection connection = new DMDBConnection();

        public double getPresentage(string stockName)
        {
            string query;

            if (stockName == "All")
            {
                query = "SELECT Inquantity FROM ingredient";
            }
            else
            {
                query = "SELECT Inquantity FROM ingredient WHERE InName = @stockName";
            }

            // Maximum quantity per ingredient is 100.
            int maxQuantityPerIngredient = 100;
            int totalQuantity = 0;
            int ingredientCount = 0;

            try
            {

                using (SqlConnection con = connection.openConnection())
                {
                    SqlCommand command = new SqlCommand(query, con);

                    if (stockName != "All")
                    {
                        command.Parameters.AddWithValue("@stockName", stockName);
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int quantity = reader.GetInt32(0);
                            totalQuantity += quantity;
                            ingredientCount++;
                        }
                    }

                    connection.closeConnection();
                }

                // Calculating the overall score
                if (ingredientCount > 0)
                {
                    int maxPossibleTotalQuantity = ingredientCount * maxQuantityPerIngredient;
                    double overallScore = (double)totalQuantity / maxPossibleTotalQuantity * 100;
                    return overallScore; // Return score.
                }
                else
                {
                    return 0; //no ingredients are found.
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; 
            }
        }

        public DataSet getStockData()
        {
            string selectQuery = "SELECT InName,Inquantity FROM ingredient;";
            DataSet results = new DataSet();

            try
            {
                using(SqlConnection con = connection.openConnection())
                {
                    SqlCommand cmd = new SqlCommand(selectQuery,con);
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.Fill(results);
                    return results;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
