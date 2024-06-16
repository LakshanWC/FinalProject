using FinalProject.MVC.Control;
using FinalProject.three_tier_architecture.BLL;
using FinalProject.three_tier_architecture.PL;
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
    public partial class PManagerHome : Form
    {
        public PManagerHome()
        {
            InitializeComponent();
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {
            BManagerHome_All home = new BManagerHome_All();
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

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee newEmp = new AddEmployee();
            this.Hide();
            newEmp.Show();
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveEmployee removeEmployee = new RemoveEmployee(); 
            this.Hide();
            removeEmployee.Show();
        }

        private void addFoodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem newFood = new AddItem();
            this.Hide();
            newFood.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           GeneralReports attendentReport = new GeneralReports();
           this.Hide();
           attendentReport.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_get_attendends_Click(object sender, EventArgs e)
        {
            BGeneralReports attendents = new BGeneralReports();
            DataSet ds = attendents.getAttendentDetails();

            if (ds != null && ds.Tables.Count > 0)
            {
                dgv_quick_details.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_get_pass_requests_Click(object sender, EventArgs e)
        {
            BPassResetRequests passRequests = new BPassResetRequests();
            DataSet ds = passRequests.getPassRequests();

            if (ds != null && ds.Tables.Count > 0)
            {
                dgv_quick_details.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
