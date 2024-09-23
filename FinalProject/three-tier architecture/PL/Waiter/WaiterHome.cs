using FinalProject.MVC.View;
using FinalProject.three_tier_architecture.PL.Chef;
using FinalProject.three_tier_architecture.PL.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Waiter
{
    public partial class WaiterHome : Form
    {
        public WaiterHome()
        {
            InitializeComponent();
        }

        public void setUserName(string userName)
        {
            lbl_userName.Text = userName;
        }

        private void btn_sideBar_one_Click(object sender, EventArgs e)
        {
            ReceivedOrder requests = new ReceivedOrder();

            if (!NewManagerHome.opendChildForms.Contains("ReceivedOrder") && NewManagerHome.opendChildForms.Count <= 2)
            {

                requests.MdiParent = this;
                requests.Show();
                NewManagerHome.opendChildForms.Add("ReceivedOrder");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_two_Click(object sender, EventArgs e)
        {
            CustomerRequests requests = new CustomerRequests();

            if (!NewManagerHome.opendChildForms.Contains("CustomerRequests") && NewManagerHome.opendChildForms.Count <= 2)
            {

                requests.MdiParent = this;
                requests.Show();
                NewManagerHome.opendChildForms.Add("CustomerRequests");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_thire_Click(object sender, EventArgs e)
        {
            ReservedTables requests = new ReservedTables();

            if (!NewManagerHome.opendChildForms.Contains("ReservedTables") && NewManagerHome.opendChildForms.Count <= 2)
            {

                requests.MdiParent = this;
                requests.Show();
                NewManagerHome.opendChildForms.Add("ReservedTables");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close(); // Close each child form
            }
            NewManagerHome.opendChildForms.Clear();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}
