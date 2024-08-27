using FinalProject.MVC.Control;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinalProject.MVC.View
{
    public partial class AddEmployee : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btn_return_home_Click(object sender, EventArgs e)
        {

            NewManagerHome mhome = new NewManagerHome();
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

        private void loadthisAgain()
        {
            Control.BAddEmployee caddEmp = new Control.BAddEmployee();

            Control.BAddEmployee cAddEmployee = new Control.BAddEmployee();
            string newEid = cAddEmployee.getNewEid();

            txt_eno.Text = newEid;
            txt_user_name.Text = newEid;

            cmb_employee_type.SelectedIndex = 0;
        }
        private void clearUi()
        {
            cmb_employee_type.SelectedIndex = 0;
            txt_name.Clear();
            txt_nic_no.Clear();
            txt_address.Clear();
            dtp_date_of_birth.Value = DateTime.Now;
            txt_tel_no.Clear();
            txt_user_name.Clear();
            txt_password.Clear();
            nud_ot_hours.Value = 0;
            nud_salary.Value = 0;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_employee_type.SelectedIndex = 0;
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

        private int getSelectedEmployeeValue(int selectedValue)
        {
            switch(selectedValue)
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
                case 6:
                    return 8;//waiter = 8
                case 7:
                    return 9;//supplier = 9
                default:
                    return -1;
                    break;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddEmployee addNewEmp = new AddEmployee();
            BAddEmployee caddEmp = new BAddEmployee();

            int selectedValue = cmb_employee_type.SelectedIndex;

            if (!string.IsNullOrEmpty(txt_name.Text) && !string.IsNullOrEmpty(txt_nic_no.Text)
                && !string.IsNullOrEmpty(dtp_date_of_birth.Text) && !string.IsNullOrEmpty(txt_tel_no.Text) 
                && !string.IsNullOrEmpty(txt_address.Text) && !string.IsNullOrEmpty(txt_user_name.Text)
                && !string.IsNullOrEmpty(txt_password.Text) && selectedValue != addNewEmp.getSelectedEmployeeValue(selectedValue))
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
                        int Etype = addNewEmp.getSelectedEmployeeValue(selectedValue);

                        bool stat =caddEmp.addEmployee(Eid, Ename, Enic, Eaddress, Edob,Etel,Eusername, 
                            Epassword,OtHours,salary,Etype);

                        if (stat)
                        {
                            TostMessage succ = new TostMessage("Employee Added","Success",3,3);
                            succ.Show();
                            clearUi();
                            loadthisAgain();
                        }
                        else
                        {
                            TostMessage error = new TostMessage("Employee Adding Faild","Faild",2,1); 
                            error.Show();
                            clearUi();
                            loadthisAgain();
                        }

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

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("addEmployee");
        }

        private void pnl_title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void pnl_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pnl_title_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
