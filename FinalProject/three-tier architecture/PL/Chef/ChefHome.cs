using FinalProject.MVC.View;
using FinalProject.three_tier_architecture.PL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Chef
{
    public partial class ChefHome : Form
    {
        public ChefHome()
        {
            InitializeComponent();
        }

        public void setUserName(string userName)
        {
            lbl_userName.Text = userName;
        }

        private void btn_sideBar_one_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("ReceivedOrder") && NewManagerHome.opendChildForms.Count <= 2)
            {
                ReceivedOrder addStock = new ReceivedOrder();
                addStock.MdiParent = this;
                addStock.Show();

                NewManagerHome.opendChildForms.Add("ReceivedOrder");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_two_Click(object sender, EventArgs e)
        {
            if (!NewManagerHome.opendChildForms.Contains("UpdateInventory") && NewManagerHome.opendChildForms.Count <= 2)
            {
                UpdateInventory addStock = new UpdateInventory();
                addStock.MdiParent = this;
                addStock.Show();

                NewManagerHome.opendChildForms.Add("UpdateInventory");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login loGIn = new Login();
            this.Hide();
            loGIn.Show();
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
