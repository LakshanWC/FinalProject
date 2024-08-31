using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Supplier
{
    public partial class CurrentSupplies : Form
    {
        public CurrentSupplies()
        {
            InitializeComponent();
        }

        private void CurrentSupplies_Load(object sender, EventArgs e)
        {
            ReportDocument rpd = new ReportDocument();
            string source = "D:\\Nibm\\C# projects\\FinalProject\\FinalProject\\three-tier architecture\\PL\\Sales&Finance\\InventoyItemReport.rpt";
            rpd.Load(source);
            crystalReportViewer1.ReportSource = rpd;
        }
    }
}
