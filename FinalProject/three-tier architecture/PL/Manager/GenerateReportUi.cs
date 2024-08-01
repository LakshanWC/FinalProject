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

                default:
                    location = string.Empty;
                    return location;
                    break;
           }
        }

        private void cmb_reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportDocument rpDoc = new ReportDocument();
            string source = seletedReport(cmb_reports.SelectedIndex);
            rpDoc.Load(source);
            crystalReportViewer1.ReportSource = rpDoc;
        }
    }
}
