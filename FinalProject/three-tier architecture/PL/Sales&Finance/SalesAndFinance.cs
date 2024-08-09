using FinalProject.MVC.View;
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
    public partial class SalesAndFinance : Form
    {
        public SalesAndFinance()
        {
            InitializeComponent();
        }

        private void addNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_side_bar_1_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("Add Stock") && NewManagerHome.opendChildForms.Count <= 2)
            {
                AddStock stock = new AddStock();
                stock.MdiParent = this;
                stock.Show();

                NewManagerHome.opendChildForms.Add("Add Stock");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_side_bar_2_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("Remove Stock") && NewManagerHome.opendChildForms.Count <= 2)
            {
                RemoveStock remStock = new RemoveStock();
                remStock.MdiParent = this;
                remStock.Show();

                NewManagerHome.opendChildForms.Add("Remove Stock");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }
    }
}
