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
    }
}
