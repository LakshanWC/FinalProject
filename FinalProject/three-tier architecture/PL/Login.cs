using FinalProject.MVC.Control;
using FinalProject.three_tier_architecture.PL;
using FinalProject.three_tier_architecture.PL.Customerr;
using FinalProject.three_tier_architecture.PL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.MVC.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Image eyeClose = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\eyeClose.jpg");
        private Image eyeOpen = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\eyeOpen.jpg");

        private void lnklbl_reset_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword obj = new ResetPassword();
            this.Hide();
            obj.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Login log =  new Login();
            log.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_userName.Text) && !string.IsNullOrEmpty(txt_Password.Text))
            {
                string userName = txt_userName.Text;
                string password = txt_Password.Text;

                Control.BLogin mylogin = new Control.BLogin();
                int myCheck = mylogin.checkLogin(userName, password);

                switch (myCheck)
                {
                    case 1:
                        //test account
                        mylogin.markAttendant(userName);
                        MessageBox.Show("welcome admin");
                        break;
                    case 2:
                        //manager
                        mylogin.markAttendant(userName);
                        NewManagerHome mHome = new NewManagerHome();
                        this.Hide();
                        mHome.Show();
                        break;
                    case 3:
                        //chef
                        mylogin.markAttendant(userName);
                        MessageBox.Show("chef GUI");
                        break;
                    case 4:
                        //cashier
                        mylogin.markAttendant(userName);
                        MessageBox.Show("casheir GUI");
                        break;
                    case 5:
                        //delivery
                        mylogin.markAttendant(userName);
                        MessageBox.Show("delivery GUI");
                        break;
                    case 6:
                        //sales
                        mylogin.markAttendant(userName);
                        MessageBox.Show("sales & finan GUI");
                        SalesAndFinanceHome saleHome = new SalesAndFinanceHome();
                        this.Hide();
                        saleHome.Show();
                        break;
                    case 7:
                        //customer
                        mylogin.markAttendant(userName);
                        CustomerHome cusHome = new CustomerHome();
                        cusHome.setUserName(userName);
                        this.Hide();
                        cusHome.Show();
                        break;
                    case 8:
                        //waiter
                        break;
                    case 9:
                        //supplier
                        break;
                    default:
                        MessageBox.Show("User Does not Exist", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
            else
            {
                MessageBox.Show("Login Credentials Can Not Be Empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }

        private void chk_view_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chk_view.Checked)
            {
                chk_view.BackgroundImage = eyeClose;
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                chk_view.BackgroundImage = eyeOpen;
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void lnklbl_reset_pass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword obj = new ResetPassword();
            this.Hide();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
