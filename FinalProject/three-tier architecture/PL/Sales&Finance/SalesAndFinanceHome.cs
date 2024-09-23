using FinalProject.MVC.View;
using FinalProject.three_tier_architecture.PL.Customerr;
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
    public partial class SalesAndFinanceHome : Form
    {
        public SalesAndFinanceHome()
        {
            InitializeComponent();
        }

        public void setUserName(string userName)
        {
            lbl_userName.Text = userName;
        }

        private void btn_sideBar_one_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("Add Stock") && NewManagerHome.opendChildForms.Count <= 2)
            {
                AddStock addStock = new AddStock();
                addStock.MdiParent = this;
                addStock.Show();

                NewManagerHome.opendChildForms.Add("Add Stock");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_two_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("Stocks") && NewManagerHome.opendChildForms.Count <= 2)
            {
                StockUi stock = new StockUi();
                stock.MdiParent = this;
                stock.Show();

                NewManagerHome.opendChildForms.Add("Stocks");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_thire_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("Transaction") && NewManagerHome.opendChildForms.Count <= 2)
            {
                Transaction stock = new Transaction();
                stock.MdiParent = this;
                stock.Show();

                NewManagerHome.opendChildForms.Add("Transaction");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void contactSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("Contact") && NewManagerHome.opendChildForms.Count <= 2)
            {
                Contact stock = new Contact();
                stock.MdiParent = this;
                stock.Show();

                NewManagerHome.opendChildForms.Add("Contact");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void attendentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialReview finRew = new FinancialReview();
            finRew.MdiParent = this;
            finRew.Show();
            
        }

        private void removeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStock rmStock = new RemoveStock();

            if (!NewManagerHome.opendChildForms.Contains("RemoveStock") && NewManagerHome.opendChildForms.Count <= 2)
            {

                rmStock.MdiParent = this;
                rmStock.Show();
                NewManagerHome.opendChildForms.Add("RemoveStock");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReportUi reports = new GenerateReportUi();
            GenerateReportUi.reportType = 1;
            reports.MdiParent = this;
            reports.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("Add Stock") && NewManagerHome.opendChildForms.Count <= 2)
            {
                AddStock addStock = new AddStock();
                addStock.MdiParent = this;
                addStock.Show();

                NewManagerHome.opendChildForms.Add("Add Stock");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void addOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("Add OT") && NewManagerHome.opendChildForms.Count <= 2)
            {
                AddOT addStock = new AddOT();
                addStock.MdiParent = this;
                addStock.Show();

                NewManagerHome.opendChildForms.Add("Add OT");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login logIn = new Login();
            this.Hide();
            logIn.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close(); // Close each child form
            }
            NewManagerHome.opendChildForms.Clear();
        }
    }
}
