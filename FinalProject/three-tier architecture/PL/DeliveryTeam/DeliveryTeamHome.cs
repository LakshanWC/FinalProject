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

namespace FinalProject.three_tier_architecture.PL.Delivery_Team
{
    public partial class DeliveryTeamHome : Form
    {
        public static string userNameDelivery;

        public DeliveryTeamHome()
        {
            InitializeComponent();
        }

        public void setUserName(string userName)
        {
            lbl_userName.Text = userName;
            userNameDelivery = userName;
        }

        private void btn_sideBar_one_Click(object sender, EventArgs e)
        {
            Delivery menu = new Delivery();

            if (!NewManagerHome.opendChildForms.Contains("Delivery") && NewManagerHome.opendChildForms.Count <= 2)
            {

                menu.MdiParent = this;
                menu.Show();
                NewManagerHome.opendChildForms.Add("Delivery");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_two_Click(object sender, EventArgs e)
        {
            Performance menu = new Performance();

            if (!NewManagerHome.opendChildForms.Contains("Perfomence") && NewManagerHome.opendChildForms.Count <= 2)
            {

                menu.MdiParent = this;
                menu.Show();
                NewManagerHome.opendChildForms.Add("Perfomence");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }
    }
}
