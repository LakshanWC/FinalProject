using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using FinalProject.MVC.View;
using FinalProject.MVC.Control;
using FinalProject.MVC;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class NewManagerHome : Form
    {
        public NewManagerHome()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        private int cusSatisfactionTarget;
        private int stockTarget;
        public static List<string> opendChildForms = new List<string>();


        private void myInit()
        {
            timer.Interval = 10;
            timer.Tick += new EventHandler(this.Timer_Tick);

            // target values for progress bars
            cusSatisfactionTarget = 60; // target value
            stockTarget = 50; // target value

            // progress bar Start values
            cpb_cutomer_satisfaction.Value = 0;
            cpb_stock_prisentage.Value = 0;

            // Start the timer
            timer.Start();


            BManagerHome_All home = new BManagerHome_All();
            int noOfRequests = home.getPasswordResetRequests();
            lbl_no_of_pass_reset.Text = Convert.ToString(noOfRequests);

            if (noOfRequests > 0)
            {
                // MessageBox.Show("Password Reset Requests Available. Please check and accept them in order" +
                //    " to enable the new passwords.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TostMessage myTost = new TostMessage("Password Reset Requests Available. " +
                    "Please check and accept them", "Notification", 1, 1);
                myTost.Show();

            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gradually decrease the progress bar values
            if (cpb_cutomer_satisfaction.Value < cusSatisfactionTarget)
            {
                cpb_cutomer_satisfaction.Value += 1;
                cpb_cutomer_satisfaction.Text = cpb_cutomer_satisfaction.Value.ToString() + "%";
            }

            if (cpb_stock_prisentage.Value < stockTarget)
            {
                cpb_stock_prisentage.Value += 1;
                cpb_stock_prisentage.Text = cpb_stock_prisentage.Value.ToString() + "%";
            }

            // Stop the timer when both progress bars reach their target values
            if (cpb_cutomer_satisfaction.Value >= cusSatisfactionTarget && cpb_stock_prisentage.Value >= stockTarget)
            {
                timer.Stop();
            }
        }

        private void NewManagerHome_Load(object sender, EventArgs e)
        {
            btn_home.PerformClick();
            Rectangle workingArea = Screen.FromControl(this).WorkingArea;
            this.Location = workingArea.Location;
            this.Size = workingArea.Size;  
            myInit();
        }

        private void pnl_side_panle_Paint(object sender, PaintEventArgs e)
        {
           // this.BackColor = Color.FromArgb(00, 00, 00);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_home.Height;
            pnl_nav.Top = btn_home.Top;
            pnl_nav.Left = btn_home.Left;
            btn_home.BackColor = Color.FromArgb(30,30,30);

            foreach (var child in this.MdiChildren)
            {
                child.Close();
                
            }
            opendChildForms.Clear();
            tlp_dash_board.Visible = true;
        }

        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_home.BackColor = Color.FromArgb(42,42,42);
        }

        private void cpb_stock_prisentage_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_enable_password_Click(object sender, EventArgs e)
        {
           
            pnl_nav.Height =  btn_enable_password.Height;
            pnl_nav.Top =  btn_enable_password.Top;
            pnl_nav.Left =  btn_enable_password.Left;
            btn_enable_password.BackColor = Color.FromArgb(30, 30, 30);
            PasswordRequest request = new PasswordRequest();

            if (!opendChildForms.Contains("passRequest"))
            {
                this.tlp_dash_board.Visible = false;
                

                request.MdiParent = this;
                request.Show();

                opendChildForms.Add("passRequest");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            pnl_nav.Height =  btn_add_employee.Height;
            pnl_nav.Top =  btn_add_employee.Top;
            pnl_nav.Left =  btn_add_employee.Left;
            btn_add_employee.BackColor = Color.FromArgb(30, 30, 30);

            if (!opendChildForms.Contains("addEmployee"))
            {
                this.tlp_dash_board.Visible = false;
                AddEmployee emp = new AddEmployee();
                emp.MdiParent = this;
                emp.Show();

                opendChildForms.Add("addEmployee");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_add_menu_item_Click(object sender, EventArgs e)
        {
            pnl_nav.Height =  btn_add_menu_item.Height;
            pnl_nav.Top =  btn_add_menu_item.Top;
            pnl_nav.Left =  btn_add_menu_item.Left;
            btn_add_menu_item.BackColor = Color.FromArgb(30, 30, 30);

            if (!opendChildForms.Contains("addItem"))
            {
                this.tlp_dash_board.Visible = false;
                AddItem itme = new AddItem();
                itme.MdiParent = this;
                itme.Show();

                opendChildForms.Add("addItem");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }


        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            Login logout = new Login();
            this.Hide();
            logout.Show();
        }

        private void btn_enable_password_Leave(object sender, EventArgs e)
        {
            btn_enable_password.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void btn_add_employee_Leave(object sender, EventArgs e)
        {
            btn_add_employee.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void btn_add_menu_item_Leave(object sender, EventArgs e)
        {
            btn_add_menu_item.BackColor = Color.FromArgb(42, 42, 42);
        }
    }
}
