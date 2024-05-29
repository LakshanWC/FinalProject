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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btn_return_home_Click(object sender, EventArgs e)
        {
            ManagerHome mhome = new ManagerHome();
            this.Hide();
            mhome.Show();
        }
    }
}
