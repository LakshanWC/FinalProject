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
                    MessageBox.Show("Password reset request been send");


                }
                else
                {
                    MessageBox.Show("Password & Retype Password must be the same", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txt_new_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_new_password.UseSystemPasswordChar = true;
            }
        }

        private void chk_view_re_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_view_re_pass.Checked)
            {
                txt_re_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_re_password.UseSystemPasswordChar = true ;
            }
        }
    }
}
