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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lnklbl_reset_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword obj = new ResetPassword();
            this.Hide();
            obj.Show();
            
        }
    }
}
