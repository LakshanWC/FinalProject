using FinalProject.MVC.Control;
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_userName.Text) && !string.IsNullOrEmpty(txt_Password.Text))
            {
                string userName = txt_userName.Text;
                string password = txt_Password.Text;

                CLogin mylogin = new CLogin();
                int myCheck = mylogin.Login(userName, password);

                switch (myCheck)
                {
                    case 1:
                        mylogin.markAttendant(userName);
                        MessageBox.Show("emp GUI");
                        break;
                    case 2:
                        mylogin.markAttendant(userName);
                        ManagerHome mHObj = new ManagerHome();
                        this.Hide();  
                        mHObj.Show();
                       // MessageBox.Show("manager GUI");
                        break;
                    case 3:
                        mylogin.markAttendant(userName);
                        MessageBox.Show("chef GUI");
                        break;
                    case 4:
                        mylogin.markAttendant(userName);
                        MessageBox.Show("casheir GUI");
                        break;
                    case 5:
                        mylogin.markAttendant(userName);
                        MessageBox.Show("delivery GUI");
                        break;
                    case 6:
                        mylogin.markAttendant(userName);
                        MessageBox.Show("sales & finan GUI");
                        break;
                    case 7:
                        mylogin.markAttendant(userName);
                        MessageBox.Show("customer GUI");
                        break;
                    case 8:
                        MessageBox.Show("welcome admin");
                        break;
                    default:
                        MessageBox.Show("User Does not Exist", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
            else
            {
                MessageBox.Show("Wrong Login Credentials ", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chk_view_CheckedChanged(object sender, EventArgs e)
        {          
            if (chk_view.Checked) {
                chk_view.BackgroundImage = eyeClose;
                txt_Password.UseSystemPasswordChar = false;
            }
            else {
                chk_view.BackgroundImage = eyeOpen;
               txt_Password.UseSystemPasswordChar = true;
            }
        }    
    }
}
