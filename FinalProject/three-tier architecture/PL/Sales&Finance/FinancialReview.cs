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

namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    public partial class FinancialReview : Form
    {
        public FinancialReview()
        {
            InitializeComponent();
        }

        private void FinancialReview_Load(object sender, EventArgs e)
        {
            cmb_seleted_filter.SelectedIndex = 0;
        }

        private void cmb_seleted_filter_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            ReportDocument rpDoc = new ReportDocument();
            string source = seletedReport(cmb_seleted_filter.SelectedIndex);
            rpDoc.Load(source);
            crystalReportViewer1.ReportSource = rpDoc; */

            LoadReportWithCustomQuery(cmb_seleted_filter.SelectedIndex);
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
