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

namespace FinalProject.three_tier_architecture.PL.Supplier
{
    public partial class SupplierHome : Form
    {
        public SupplierHome()
        {
            InitializeComponent();
        }

        private void btn_sideBar_two_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();

            if (!NewManagerHome.opendChildForms.Contains("Inventory") && NewManagerHome.opendChildForms.Count <= 2)
            {

                inventory.MdiParent = this;
                inventory.Show();
                NewManagerHome.opendChildForms.Add("Inventory");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_one_Click(object sender, EventArgs e)
        {
            StockOrderRequest requests = new StockOrderRequest();

            if (!NewManagerHome.opendChildForms.Contains("StockOrderRequests") && NewManagerHome.opendChildForms.Count <= 2)
            {

                requests.MdiParent = this;
                requests.Show();
                NewManagerHome.opendChildForms.Add("StockOrderRequests");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void btn_sideBar_thire_Click(object sender, EventArgs e)
        {
            //dont remove or use this
        }

        private void btn_sideBar_thire_Click_1(object sender, EventArgs e)
        {
            CurrentSupplies currntSup = new CurrentSupplies();
            currntSup.MdiParent = this;
            currntSup.Show();
        }
    }
}
