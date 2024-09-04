using FinalProject.MVC;
using FinalProject.MVC.Control;
using FinalProject.three_tier_architecture.BLL;
using FinalProject.three_tier_architecture.PL.Delivery_Team;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class Register : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Register()
        {
            InitializeComponent();
        }

        private void cmb_employee_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BAddEmployee caddEmp = new BAddEmployee();

            if (cmb_employee_type.SelectedIndex != 1)
            {
                lbl_email.Visible = false;
                txt_email.Visible = false;

                BAddEmployee cAddEmployee = new BAddEmployee();
                string newEid = cAddEmployee.getNewEid();

                txt_eno.Text = newEid;
                txt_user_name.Text = newEid;
            }
            else if(cmb_employee_type.SelectedIndex == 1)
            {

                BRegister cAddEmployee = new BRegister();
                string newEid = cAddEmployee.genarateCustomerId();

                txt_eno.Text = newEid;
                txt_user_name.Text = newEid;

                lbl_email.Visible = true;
                txt_email.Visible = true;

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearUi();
        }

        private void clearUi()
        {
            txt_eno.Clear();
            cmb_employee_type.SelectedIndex = 0;
            txt_name.Clear();
            txt_nic_no.Clear();
            dtp_date_of_birth.Value = DateTime.Now;
            txt_tel_no.Clear();
            txt_address.Clear();
            txt_user_name.Clear();
            txt_password.Clear();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cmb_employee_type.SelectedIndex = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_eno.Text)&& !string.IsNullOrEmpty(txt_name.Text) && !string.IsNullOrEmpty(txt_nic_no.Text) 
                && !string.IsNullOrEmpty(txt_tel_no.Text) && !string.IsNullOrEmpty(txt_address.Text) && !string.IsNullOrEmpty(txt_user_name.Text)
                && !string.IsNullOrEmpty(txt_password.Text)&& cmb_employee_type.SelectedIndex != 0)
            {


                string eno = txt_eno.Text;
                string employeeType = cmb_employee_type.SelectedIndex.ToString();
                string name = txt_name.Text;
                string nicNo = txt_nic_no.Text;
                DateTime dob = dtp_date_of_birth.Value;
                string telNo = txt_tel_no.Text;
                string address = txt_address.Text;
                string userName =txt_user_name.Text;
                string password = txt_password.Text;

                BRegister regs = new BRegister();
                int stat = 0;

                if (cmb_employee_type.SelectedIndex == 1)
                {
                    stat = regs.addCustomer(eno,name, nicNo,address,dob,txt_email.Text,telNo,userName,password);

                    if (stat > 0)
                    {
                        TostMessage succ = new TostMessage("Registerd Successfully", "Success", 3, 3);
                        succ.Show();
                        clearUi();
                    }
                    else
                    {
                        TostMessage error = new TostMessage("Registering Faild", "Faild", 2, 1);
                        error.Show();
                        clearUi();
                    }
                }
                else if(cmb_employee_type.SelectedIndex != 0 && cmb_employee_type.SelectedIndex != 1)
                {
                    int type = getSelectedEmployeeValue(cmb_employee_type.SelectedItem.ToString());

                    int sta = regs.addEmployee(eno,name,nicNo,address,dob,telNo,userName,password,type);

                    if (sta > 0)
                    {
                        TostMessage succ = new TostMessage("Registerd Successfully", "Success", 3, 3);
                        succ.Show();
                        clearUi();
                    }
                    else
                    {
                        TostMessage error = new TostMessage("Registering Faild", "Faild", 2, 1);
                        error.Show();
                        clearUi();
                    }
                }

            }
        }

        private int getSelectedEmployeeValue(string selectedValue)
        {
            switch (selectedValue)
            {
                case "Manager":
                    return 2; // Manager type = 2
                case "Chef":
                    return 3; // Chef type = 3
                case "Cashier":
                    return 4; // Cashier type = 4
                case "Delivery":
                    return 5; // Delivery team = 5
                case "Sales & Finance":
                    return 6; // Sales & Finance = 6
                case "Waiter":
                    return 8; // Waiter = 8
                case "Supplier":
                    return 9; // Supplier = 9
                default:
                    return -1; // Unknown type
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
