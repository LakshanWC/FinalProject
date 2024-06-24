using FinalProject.three_tier_architecture.BLL;
using FinalProject.three_tier_architecture.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class UpdateEmployeeDetails : Form
    {
        private Image eyeClose = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\eyeClose.jpg");
        private Image eyeOpen = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\eyeOpen.jpg");

        public UpdateEmployeeDetails()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_search_eno.Text))
            {
                BRemoveEmployee search = new BRemoveEmployee();
                DataSet details = search.getEmployeeDetails(txt_search_eno.Text);

                if (details.Tables.Count > 0 && details.Tables[0].Rows.Count > 0)
                {
                    DataRow row = details.Tables[0].Rows[0];
                    txt_eno.Text = row["Eid"].ToString();
                    txt_name.Text = row["Ename"].ToString();
                    int accountStatus = Convert.ToInt32(row["accountStatus"]);
                    if (accountStatus == 1) rbtn_enable.Checked = true;
                    else rbtn_diable.Checked = true;
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

        private void chk_view_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_view.Checked)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
           string eID = txt_eno.Text;
           string eName = txt_name.Text;
           string nicNo = txt_nic_no.Text;
           string eAddress = txt_address.Text;
           DateTime dob = dtp_DOB.Value;
           string eTel = txt_tel_no.Text;
           string eUserName = txt_user_name.Text;
           string ePassword = txt_password.Text;
           int oTHours = Convert.ToInt32(nud_ot_hours.Value);
           int salary = Convert.ToInt32(nud_salary.Value);
           int accountStatus= 0;
            if(rbtn_enable.Checked)
            {
                accountStatus = 1;
            }
            else if(rbtn_diable.Checked)
            {
                accountStatus = 0;
            }

            DUpdateEmployee details = new DUpdateEmployee();
            bool results = details.updateEmpDetails( eID,eName, nicNo, eAddress,
             dob,eTel,eUserName,ePassword,oTHours,salary,accountStatus);

            if (results)
            {
                MessageBox.Show("Update succsessful");
            }
            else MessageBox.Show("Update fail");

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_eno.Clear();
            txt_name.Clear();
            txt_nic_no.Clear();
            txt_address.Clear();
            dtp_DOB.Value.ToLocalTime();
            txt_tel_no.Clear();
            txt_user_name.Clear();
            txt_password.Clear();
            nud_ot_hours.Value = 0;
            nud_salary.Value = 0;
            rbtn_enable.Checked = false;
            rbtn_diable.Checked = false;
        }
    }
    
}
