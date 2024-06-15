using CrystalDecisions.CrystalReports.Engine;
using FinalProject.MVC.Model;
using FinalProject.three_tier_architecture.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class GeneralReports : Form
    {
        public GeneralReports()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                BGeneralReports reports = new BGeneralReports();
                DataSet ds = reports.getAttendentDetails();

                AttendentReport rtp = new AttendentReport();
                rtp.Load("D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\AttendentReport.rpt"); // Use the correct path or resource name
                rtp.SetDataSource(ds.Tables[0]);

                crystalReportViewer1.ReportSource = rtp;
            }
            catch (Exception ex)
            {
               // MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
