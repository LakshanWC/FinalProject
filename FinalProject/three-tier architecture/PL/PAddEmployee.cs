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
    public partial class PAddEmployee : Form
    {
        public PAddEmployee()
        {
            InitializeComponent();
        }

        private void btn_return_home_Click(object sender, EventArgs e)
        {

            PManagerHome mhome = new PManagerHome();
            this.Hide();
            mhome.Show();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Control.BAddEmployee caddEmp = new Control.BAddEmployee();

            Control.BAddEmployee cAddEmployee = new Control.BAddEmployee();
            string newEid = cAddEmployee.getNewEid();

            txt_eno.Text = newEid;
            txt_user_name.Text = newEid;

            cmb_employee_type.SelectedIndex = 0;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_employee_type.SelectedIndex = 0;
            txt_eno.Clear();
            txt_name.Clear();
            txt_nic_no.Clear();
            txt_address.Clear();
            dtp_date_of_birth.Value = DateTime.Now;
            txt_tel_no.Clear() ;
            txt_user_name.Clear();
            txt_password.Clear();
            nud_ot_hours.Value = 0;
            nud_salary.Value = 0; 
        }

        private int getSelectedEmployeeValue()
        {
            int numForSelectedName = cmb_employee_type.SelectedIndex;

            switch(numForSelectedName)
            {
                case 1:
                    return 2; //manager type =2
                    break;
                case 2:
                    return 3; //chef type = 3
                    break;
                case 3:
                    return 4; //cashier =4
                    break;
                case 4:
                   return 5; //delivery team = 5
                   break;
                case 5:
                    return 6; //sales & finance = 6
                    break;
                default:
                    return -1;
                    break;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PAddEmployee addNewEmp = new PAddEmployee();
            Control.BAddEmployee caddEmp = new Control.BAddEmployee();

            int selectedValue = -1;

            if (string.IsNullOrEmpty(txt_name.Text) && string.IsNullOrEmpty(txt_nic_no.Text)
                && string.IsNullOrEmpty(dtp_date_of_birth.Text) && string.IsNullOrEmpty(txt_tel_no.Text) 
                && string.IsNullOrEmpty(txt_address.Text) && string.IsNullOrEmpty(txt_user_name.Text)
                && string.IsNullOrEmpty(txt_password.Text) && selectedValue != addNewEmp.getSelectedEmployeeValue())
            {
                if(nud_ot_hours.Value > 0 && nud_salary.Value > 0)
                { 

                    if (dtp_date_of_birth.Value ==  DateTime.Today.Date)
                    {
                        MessageBox.Show(" Please enter your actual birthdate to continue !", "Invalid Date Of Birth"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string Eid = txt_eno.Text;
                        string Ename = txt_name.Text;
                        string Enic = txt_nic_no.Text;
                        string Eaddress = txt_address.Text;
                        DateTime Edob = dtp_date_of_birth.Value;
                        string Etel = txt_tel_no.Text;
                        string Eusername = txt_user_name.Text;
                        string Epassword = txt_password.Text;
                        double OtHours = Convert.ToDouble(nud_ot_hours.Value);
                        double salary = Convert.ToDouble(nud_salary.Value);
                        int Etype = addNewEmp.getSelectedEmployeeValue();

                        caddEmp.addEmployee(Eid, Ename, Enic, Eaddress, Edob,Etel,Eusername, 
                            Epassword,OtHours,salary,Etype);

                    }

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

        private void txt_tel_no_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_tel_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      //  private void btn_generate_username_Click(object sender, EventArgs e)
      //  {
          
       // }

        private void btn_generate_pass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Please provide a name","error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control.BAddEmployee cAddEmp = new Control.BAddEmployee();
                txt_password.Text = cAddEmp.randomPasswordGen(txt_name.Text);
            }
        }
    }
}
