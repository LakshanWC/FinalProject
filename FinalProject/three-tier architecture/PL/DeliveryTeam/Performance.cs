using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using FinalProject.MVC.Model;
using FinalProject.three_tier_architecture.PL.DeliveryTeam;
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

namespace FinalProject.three_tier_architecture.PL.Delivery_Team
{
    public partial class Performance : Form
    {
        public Performance()
        {
            InitializeComponent();
        }

        private void Performance_Load(object sender, EventArgs e)
        {
            // ReportDocument rpd = new ReportDocument();
            // rpd.Load("D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\DeliveryTeam\\DliveryPerformance.rpt");
            // crystalReportViewer1.ReportSource = rpd;
            setData();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {

        }

        private void setData()
        {
            // Define your SQL query to select specific columns
            string query = @"
                SELECT delivedBy, itemName,orderId,DeliveryStarted,DeliveryEnded
                FROM delivery 
                WHERE delivedBy = @UniqeKey";

            DMDBConnection connection = new DMDBConnection();

            // Create a connection to the database
            using (SqlConnection conn = connection.openConnection())
            {
                // Create a command
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UniqeKey", DeliveryTeamHome.userNameDelivery);

                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                // Create a dataset
                DataSet ds = new DataSet();

                // Fill the dataset with data
                da.Fill(ds, "tblorder");

                // Load the report
                ReportDocument rpd = new ReportDocument();
                string source = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\DeliveryTeam\\DeliveryReport.rpt";
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
