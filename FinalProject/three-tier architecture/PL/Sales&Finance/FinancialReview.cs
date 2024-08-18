using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        {
            ReportDocument rpDoc = new ReportDocument();
            string source = seletedReport(cmb_seleted_filter.SelectedIndex);
            rpDoc.Load(source);
            crystalReportViewer1.ReportSource = rpDoc;
        }

        private string seletedReport(int type)
        {
            string location;

            switch (type)
            {
                case 0:
                    location = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Sales&Finance\\FinancialExpenseReport.rpt";
                    return location;
                    break;

                default:
                    location = string.Empty;
                    return location;
                    break;
            }
        }
    }
}
