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
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class GenerateReportUi : Form
    {
        public static int reportType = 0;

        public GenerateReportUi()
        {
            InitializeComponent();
        }


        private void ReportUi_Load(object sender, EventArgs e)
        {
            ReportDocument rpd = new ReportDocument();
            string source = seletedReport(reportType);
            rpd.Load(source);
            crystalReportViewer1.ReportSource = rpd;
        }

        private string seletedReport(int type)
        {
            string location;

           switch (type)
           {
                case 0:
                    location = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\AttendentReport.rpt";
                    txt_current_report.Text = "Attendent Report";
                    cmb_reports.SelectedIndex = 0;
                    return location;
                    break;

                case 1:
                    location ="D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Manager\\IncomeReport.rpt";
                    txt_current_report.Text = "Income Report";
                    cmb_reports.SelectedIndex = 1;
                    return location;
                    break;

                case 2:
                    location ="D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Sales&Finance\\FinancialExpenseReport.rpt";
                    txt_current_report.Text = "FinancialExpense Report";
                    cmb_reports.SelectedIndex = 2;
                    return location;
                    break;

                case 3:
                    location ="D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Sales&Finance\\InventoyItemReport.rpt";
                    txt_current_report.Text = "InventoyItem Report";
                    cmb_reports.SelectedIndex = 3;
                    return location;
                    break;

                default:
                    location = null;
                    return location;
                    break;
           }
        }

        private void cmb_reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportDocument rpDoc = new ReportDocument();
            string source = seletedReport(cmb_reports.SelectedIndex);
            if (source == null)
            {
                foundBoth();
            }
            else
            {
                rpDoc.Load(source);
                crystalReportViewer1.ReportSource = rpDoc;
            }
        }

        private void foundBoth()
        {
            
            
                DMDBConnection connection = new DMDBConnection();

                // Query for tblorder
                string orderQuery = @"
                    SELECT UniqeKey, Cno, ItemName,Oquantity, Odate, OrderStatus,Price
                    FROM tblorder ";

                // Query for specialOrderRequest
                string specialOrderQuery = @"
                    SELECT SORid, quantity, itemName, Price, orderStat, SpOrderDate
                    FROM specialOrderRequest";

                // Create and fill datasets
                DataSet ds = new DataSet();

                using (SqlConnection conn = connection.openConnection())
                {
                    // Fill tblorder data
                    SqlCommand cmdOrder = new SqlCommand(orderQuery, conn);
                    SqlDataAdapter daOrder = new SqlDataAdapter(cmdOrder);
                    daOrder.Fill(ds, "OrderDetails");

                    // Fill specialOrderRequest data
                    SqlCommand cmdSpecialOrder = new SqlCommand(specialOrderQuery, conn);
                // Use appropriate parameter
                    SqlDataAdapter daSpecialOrder = new SqlDataAdapter(cmdSpecialOrder);
                    daSpecialOrder.Fill(ds, "SpecialOrderDetails");
                }

                // Load the report
                ReportDocument rpd = new ReportDocument();
                string source = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Manager\\ReportIncome.rpt";
                rpd.Load(source);

                // Set datasets as data sources for the report
                rpd.SetDataSource(ds.Tables["OrderDetails"]);
                // Optionally add another data source or use subreports for SpecialOrderDetails

                // Set the report source for the viewer
                crystalReportViewer1.ReportSource = rpd;
                crystalReportViewer1.Refresh();
            
        }

    }
}
