using CrystalDecisions.CrystalReports.Engine;
using FinalProject.MVC;
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
        public static string currentOrderId = "";

        public OrderConfirmation()
        {
            InitializeComponent();
        }

        private void OrderConfirmation_Load(object sender, EventArgs e)
        {
            setOrderIdText(currentOrderId);
        }

        private void setOrderIdText(string orderId)
        {
            if(orderId != null)
            {
                txt_current_report.Text = orderId;
            }
        }

        private void btn_update_details_Click(object sender, EventArgs e)
        {

            findId();
        }


        private void findId()
        {
            DMDBConnection coon = new DMDBConnection();

            string selectQuery = "SELECT SORid FROM specialOrderRequest WHERE SORid LIKE @id + '%';";
            string select2Query = "SELECT UniqeKey FROM tblorder WHERE UniqeKey LIKE @id + '%';";

            using (SqlConnection conn = coon.openConnection())
            {
                // Execute first query
                SqlCommand cmdSelect = new SqlCommand(selectQuery, conn);
                cmdSelect.Parameters.AddWithValue("@id", txt_current_report.Text);
                SqlDataAdapter daSelect = new SqlDataAdapter(cmdSelect);
                DataSet ds1 = new DataSet();
                daSelect.Fill(ds1, "SpecialOrderRequest");

                // Execute second query
                SqlCommand cmdSelect2 = new SqlCommand(select2Query, conn);
                cmdSelect2.Parameters.AddWithValue("@id", txt_current_report.Text);
                SqlDataAdapter daSelect2 = new SqlDataAdapter(cmdSelect2);
                DataSet ds2 = new DataSet();
                daSelect2.Fill(ds2, "TblOrder");

                if (ds1.Tables[0].Rows.Count == 0 && ds2.Tables[0].Rows.Count > 0)
                {
                    // No special orders found
                    TostMessage nof = new TostMessage("No Special orders were found", "Warning", 1, 1);
                    nof.Show();
                    DataRow row = ds2.Tables[0].Rows[0]; // Get the first row
                    foundNormalOnly(row["UniqeKey"].ToString());
                }
                else if (ds2.Tables[0].Rows.Count == 0 && ds1.Tables[0].Rows.Count > 0)
                {
                    // No normal orders found
                    TostMessage nof = new TostMessage("No Normal orders were found", "Warning", 1, 1);
                    nof.Show();
                    DataRow row = ds1.Tables[0].Rows[0]; // Get the first row
                    foundSpecialOnly(row["SORid"].ToString());
                }
                else if (ds2.Tables[0].Rows.Count == 0 && ds1.Tables[0].Rows.Count == 0)
                {
                    // No orders found in both tables
                    TostMessage nof = new TostMessage("No orders found in either table", "Warning", 1, 1);
                    nof.Show();
                }
                else
                {
                    // Found both
                    DataRow rowSpecial = ds1.Tables[0].Rows[0]; // Get the first row from specialOrderRequest
                    foundBoth(rowSpecial["SORid"].ToString());
                }
            }
        }

        private void foundBoth(string id)
        {
            if (id != null)
            {
                DMDBConnection connection = new DMDBConnection();

                // Query for tblorder
                string orderQuery = @"
                    SELECT o.UniqeKey, o.Cno, o.ItemName,o.Oquantity, o.Odate, o.OrderStatus,o.Price
                    FROM tblorder o
                    WHERE o.UniqeKey = @UniqeKey";

                // Query for specialOrderRequest
                string specialOrderQuery = @"
                    SELECT s.SORid, s.quantity, s.itemName, s.Price, s.orderStat, s.SpOrderDate
                    FROM specialOrderRequest s
                    WHERE s.SORid = @SORid";

                // Create and fill datasets
                DataSet ds = new DataSet();

                using (SqlConnection conn = connection.openConnection())
                {
                    // Fill tblorder data
                    SqlCommand cmdOrder = new SqlCommand(orderQuery, conn);
                    cmdOrder.Parameters.AddWithValue("@UniqeKey", id);
                    SqlDataAdapter daOrder = new SqlDataAdapter(cmdOrder);
                    daOrder.Fill(ds, "OrderDetails");

                    // Fill specialOrderRequest data
                    SqlCommand cmdSpecialOrder = new SqlCommand(specialOrderQuery, conn);
                    cmdSpecialOrder.Parameters.AddWithValue("@SORid", id);  // Use appropriate parameter
                    SqlDataAdapter daSpecialOrder = new SqlDataAdapter(cmdSpecialOrder);
                    daSpecialOrder.Fill(ds, "SpecialOrderDetails");
                }

                // Load the report
                ReportDocument rpd = new ReportDocument();
                string source = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Customerr\\CrystalReport1.rpt";
                rpd.Load(source);

                // Set datasets as data sources for the report
                rpd.SetDataSource(ds.Tables["OrderDetails"]);
                // Optionally add another data source or use subreports for SpecialOrderDetails

                // Set the report source for the viewer
                crystalReportViewer1.ReportSource = rpd;
                crystalReportViewer1.Refresh();
            }
        }


        private void foundNormalOnly(string uniqeId)
        {

            // Define your SQL query to select specific columns
            string query = @"
                SELECT UniqeKey, ItemName, Oquantity, Odate, Price ,Odate
                FROM tblorder 
                WHERE UniqeKey = @UniqeKey";

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
                string source = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Customerr\\NormalOnly.rpt";
                rpd.Load(source);

                // Set the dataset as the data source for the report
                rpd.SetDataSource(ds.Tables["tblorder"]);

                // Set the report source for the viewer
                crystalReportViewer1.ReportSource = rpd;
                crystalReportViewer1.Refresh();

            }
        }

        private void foundSpecialOnly(string uniqeId)
        {
            // Define your SQL query to select specific columns

            string query = @"
                    SELECT SORid, quantity, itemName, Price, orderStat, SpOrderDate
                    FROM specialOrderRequest 
                    WHERE SORid = @UniqeKey";

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
                da.Fill(ds, "specialOrderRequest");

                // Load the report
                ReportDocument rpd = new ReportDocument();
                string source = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Customerr\\SpecialOnly.rpt";
                rpd.Load(source);

                // Set the dataset as the data source for the report
                rpd.SetDataSource(ds.Tables["specialOrderRequest"]);

                // Set the report source for the viewer
                crystalReportViewer1.ReportSource = rpd;
                crystalReportViewer1.Refresh();
            }
        }
    }
}