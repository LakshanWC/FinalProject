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
            ReportDocument rpd = new ReportDocument();
            rpd.Load("D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\DeliveryTeam\\DliveryPerformance.rpt");
            crystalReportViewer1.ReportSource = rpd;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {

        }
    }
}
