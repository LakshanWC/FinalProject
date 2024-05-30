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
    public partial class ResetPassword : Form
    {
       private Image eyeClose = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\eyeClose.jpg");
       private Image eyeOpen = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\eyeOpen.jpg");

        Login objLog = new Login();

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_new_password.Clear();
            txt_re_password.Clear();
            txt_username.Clear();
        }

        private void btn_pass_request_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_new_password.Text) &&
                !string.IsNullOrEmpty(txt_username.Text) &&
                !string.IsNullOrEmpty(txt_re_password.Text))
            {
                if (txt_new_password.Text == txt_re_password.Text)
                {
                    string username = txt_username.Text;
                    string newPass = txt_new_password.Text;
                    CResetPassword rePass = new CResetPassword();
                    Boolean mycheck = rePass.requestExist(username);

                    if (mycheck == true) {
                        MessageBox.Show("Request already exists. Please wait until the manager accepts your request.",
                        "Request exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_username.Clear();
                        txt_new_password.Clear();
                        txt_re_password.Clear();
                    }
                    else
                    {
                        Boolean checkPass = rePass.resetPassword(username, newPass);

                        if (checkPass == true)
                        {
                            MessageBox.Show("Password Reset Request send seccsessfuly ", "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Hide();                         
                            objLog.Show();
                            

                        }
                        else MessageBox.Show("UserName does not exist", "UserName Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Clear();
                        txt_new_password.Clear();
                        txt_re_password.Clear();
                    }
                                         
                }
                else
                {
                    MessageBox.Show("Password & Retype Password must be the same", "Password Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled", "Empty Value Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chk_view_new_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_view_new_pass.Checked)
            {
                chk_view_new_pass.BackgroundImage=eyeClose;
                txt_new_password.UseSystemPasswordChar = false;
            }
            else
            {
                chk_view_new_pass.BackgroundImage =eyeOpen;
                txt_new_password.UseSystemPasswordChar = true;
            }
        }

        private void chk_view_re_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_view_re_pass.Checked)
            {
                chk_view_re_pass.BackgroundImage=eyeClose;
                txt_re_password.UseSystemPasswordChar = false;
            }
            else
            {
                chk_view_re_pass.BackgroundImage =eyeOpen;
                txt_re_password.UseSystemPasswordChar = true ;
            }
        }

        private void btn_go_to_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            objLog.Show();
        }
    }
}
