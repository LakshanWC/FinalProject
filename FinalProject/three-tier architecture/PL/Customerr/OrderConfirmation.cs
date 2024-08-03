using CrystalDecisions.CrystalReports.Engine;
using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class OrderConfirmation : Form
    {
        public OrderConfirmation()
        {
            InitializeComponent();
        }

        private void OrderConfirmation_Load(object sender, EventArgs e)
        {

            // Define your SQL query to select specific columns
            string query = @"
                SELECT UniqeKey, Cno, Oquantity, Odate, Price 
                FROM tblorder 
                WHERE UniqeKey = @UniqeKey";

            string uniqeId = "dd026b1c-17d1-47a8-bba8-955cc2ad811a";

            DMDBConnection connection = new DMDBConnection();

            // Create a connection to the database
            using (SqlConnection conn = connection.openConnection())
            {
                // Create a command
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UniqeKey", uniqeId);

                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                // Create a dataset
                DataSet ds = new DataSet();

                // Fill the dataset with data
                da.Fill(ds, "tblorder");

                // Load the report
                ReportDocument rpd = new ReportDocument();
                string source = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Customerr\\BillReport.rpt";
                rpd.Load(source);

                // Set the dataset as the data source for the report
                rpd.SetDataSource(ds.Tables["tblorder"]);

                // Set the report source for the viewer
                crystalReportViewer1.ReportSource = rpd;
                crystalReportViewer1.Refresh();
            }
        }
    }
}
