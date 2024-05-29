using FinalProject.MVC.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.MVC.View
{
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {
            CManagerHome_All home = new CManagerHome_All();
            int noOfRequests = home.getPasswordResetRequests();
            nud_pass_reset_requests.Value = noOfRequests;

            if(noOfRequests > 0 )
            {
               // MessageBox.Show("Password Reset Requests Available. Please check and accept them in order" +
                //    " to enable the new passwords.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TostMessage myTost = new TostMessage("Password Reset Requests Available. " +
                    "Please check and accept them", "Notification",1,1);
                myTost.Show();

            }
        }

        private void passwordResetRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordRequest passRequestObj = new PasswordRequest();
            this.Hide();
            passRequestObj.Show();
        }
    }
}
