using FinalProject.three_tier_architecture.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject.MVC.View
{
    public partial class PRemoveEmployee : Form
    {
        private Image eyeClose = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\eyeClose.jpg");
        private Image eyeOpen = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\eyeOpen.jpg");

        public PRemoveEmployee()
        {
            InitializeComponent();
        }

        private void btn_return_home_Click(object sender, EventArgs e)
        {
            PManagerHome mHome = new PManagerHome();
            this.Hide();
            mHome.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_search_eno.Text))
            {
                BRemoveEmployee empDetails = new BRemoveEmployee();
                DataSet details = empDetails.getEmployeeDetails(txt_search_eno.Text);


                if (details.Tables.Count > 0 && details.Tables[0].Rows.Count > 0)
                {
                    DataRow row = details.Tables[0].Rows[0];
                    txt_eno.Text = row["Eid"].ToString();
                    txt_name.Text = row["Ename"].ToString();
                    txt_nic_no.Text = row["Enic"].ToString();
                    txt_address.Text = row["Eaddress"].ToString();
                    dtp_DOB.Text = row["Edob"].ToString();
                    txt_user_name.Text =row["Eusername"].ToString();
                    txt_password.Text = row["Epassword"].ToString();
                    nud_ot_hours.Value = row.IsNull("OtHours") ? 0 : Convert.ToInt32(row["OtHours"]);
                    nud_salary.Value = row.IsNull("salary") ? 0 : Convert.ToDecimal(row["salary"]);

                    txt_search_eno.Clear();

                }
                else
                {
                    MessageBox.Show("Employee ID is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                }
            }
            else
            {
                MessageBox.Show("No data found for the specified employee number.");
            }


        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            BRemoveEmployee removeEmp = new BRemoveEmployee();
            int results;

            if (!string.IsNullOrEmpty(txt_search_eno.Text))
            {
                if (cb_diable_account.Checked)
                {
                    DialogResult result = MessageBox.Show("This action will disable the selected account without deleting it.Are you sure you want to proceed ?",
                         "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        results = removeEmp.removeEmployee(txt_search_eno.Text, 1);
                        if (results == 1)
                        {
                            TostMessage showToast = new TostMessage("Employee Removed succsessfuly", "Succsess", 3, 3);
                            showToast.Show();
                        }
                        else if (results == 0)
                        {
                            TostMessage showToast = new TostMessage("Employee ID not Found", "Error", 2, 2);
                            showToast.Show();
                        }
                        else
                        {
                            TostMessage showToast = new TostMessage("Unexpected Error", "Error", 2, 2);
                            showToast.Show();
                        }

                    }
                    else if (result == DialogResult.Cancel)
                    {
                        results = removeEmp.removeEmployee(txt_search_eno.Text, 0);


                    }
                }
                else
                {
                    results = removeEmp.removeEmployee(txt_search_eno.Text, 0);
                    if (results == 1)
                    {
                        TostMessage showToast = new TostMessage("Account Disabled Succsessfuly","Succsess",3,3);
                        showToast.Show();
                    }
                    else if (results == 0)
                    {
                        TostMessage showToast = new TostMessage("Employee ID not Found", "Error", 2, 2);
                        showToast.Show();
                    }
                    else
                    {
                        TostMessage showToast = new TostMessage("Unexpected Error", "Error", 2, 2);
                        showToast.Show();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Search an Employee first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chk_view_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_view.Checked)
            {
                chk_view.BackgroundImage = eyeClose;
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                chk_view.BackgroundImage = eyeOpen;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_eno.Clear();
            txt_name.Clear();
            txt_address.Clear();
            txt_nic_no.Clear();
            txt_password.Clear();
            txt_user_name.Clear();
            txt_tel_no.Clear();
            nud_ot_hours.Value = 0;
            nud_salary.Value = 0;
            dtp_DOB.Value = DateTime.Now;
        }

        private void cb_diable_account_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
