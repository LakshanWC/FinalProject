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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            CAddEmployee cAddEmployee = new CAddEmployee();
            string newEid = cAddEmployee.getNewEid();

            txt_eno.Text = newEid;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) && string.IsNullOrEmpty(txt_nic_no.Text)
                && string.IsNullOrEmpty(dtp_date_of_birth.Text) && string.IsNullOrEmpty(txt_tel_no.Text) 
                && string.IsNullOrEmpty(txt_address.Text) && string.IsNullOrEmpty(txt_user_name.Text)
                && string.IsNullOrEmpty(txt_password.Text))
            {
                if(nud_ot_hours.Value > 0 && nud_salary.Value > 0)
                {
                    TostMessage myTost = new TostMessage("New Employee Added Succsessfuly","Success",3,3);
                    myTost.Show();
                }
                else
                {
                    MessageBox.Show("Please Fill Out All Feilds !", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Fill Out All Feilds !", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
