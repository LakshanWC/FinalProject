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
                    // location = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\AttendentReport.rpt";
                    location = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\AttendentsLog.rpt";
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
          if(cmb_reports.SelectedIndex == 4)
            {
                cmb_seleted_filter.Visible = true;
                cmb_seleted_filter.SelectedIndex = 0;
            }
            else
            {
                cmb_seleted_filter.Visible = false;
            }

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

            string orderQuery = @"
            SELECT UniqeKey, 
                Cno, 
                ItemName, 
                SUM(Oquantity) AS TotalQuantity, 
                Odate, 
                OrderStatus, 
                SUM(Price * Oquantity) AS TotalPrice
            FROM tblorder
            GROUP BY UniqeKey, Cno, ItemName, Odate, OrderStatus";


                using (SqlConnection conn = connection.openConnection())
                {
                    // Fill tblorder data
                    SqlCommand cmdOrder = new SqlCommand(orderQuery, conn);
                    SqlDataAdapter daOrder = new SqlDataAdapter(cmdOrder);
                   // daOrder.Fill(ds, "OrderDetails");

                /*
                    // Fill specialOrderRequest data
                    SqlCommand cmdSpecialOrder = new SqlCommand(specialOrderQuery, conn);
                // Use appropriate parameter
                    SqlDataAdapter daSpecialOrder = new SqlDataAdapter(cmdSpecialOrder);
                    daSpecialOrder.Fill(ds, "SpecialOrderDetails");*/
                }


                // Load the report
                ReportDocument rpd = new ReportDocument();
                string source = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Manager\\NormalReportIncome.rpt";
                rpd.Load(source);

                // Set datasets as data sources for the report
               // rpd.SetDataSource(ds.Tables["OrderDetails"]);
                // Optionally add another data source or use subreports for SpecialOrderDetails

                // Set the report source for the viewer
                crystalReportViewer1.ReportSource = rpd;
                crystalReportViewer1.Refresh();
            
        }
        
        private void cmb_seleted_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   LoadReportWithCustomQuery(cmb_seleted_filter.SelectedIndex);
        }

        private void LoadReportWithCustomQuery(int filterType)
        {
            DMDBConnection connection = new DMDBConnection();

            // Define SQL query for filterType
            string sqlQuery = GetSQLQuery(filterType);

            DataSet ds = new DataSet();
            using (SqlConnection con = connection.openConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(ds, "TransactionLog"); // Fill the DataSet with query result
            }

            // Load the Crystal Report
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Sales&Finance\\FinancialExpenseReport.rpt");

            // Set the data source 
            reportDocument.SetDataSource(ds.Tables["TransactionLog"]);

            // Display the report 
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private string GetSQLQuery(int filterType)
        {
            string query = string.Empty;

            switch (filterType)
            {
                case 0: // All data
                    query = "SELECT * FROM TransactionLog WHERE OrderId = 'Purchased Stocks'";
                    break;
                case 1: // Monthly data
                    query = "SELECT * FROM TransactionLog WHERE MONTH(LogDate) = MONTH(GETDATE()) AND OrderId = 'Purchased Stocks'";
                    break;
                case 2: // Yearly data
                    query = "SELECT * FROM TransactionLog WHERE YEAR(LogDate) = YEAR(GETDATE()) AND OrderId = 'Purchased Stocks'";
                    break;
                    // Add more cases as needed
            }
            return query;
        }
    }
}
