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
    public partial class PasswordRequest : Form
    {
        public PasswordRequest()
        {
            InitializeComponent();
        }

        private void PasswordRequest_Load(object sender, EventArgs e)
        {
            CPassResetRequests passRsetObj = new CPassResetRequests();
            DataSet ds = passRsetObj.getPassRequests();

            if(ds.Tables.Count > 0 )
            {
                dgv_pass_requests.DataSource = ds.Tables[0];
            }
           
        }

        private void dgv_pass_requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int checkedRows = 0;
            try
            {
                if (e.ColumnIndex == dgv_pass_requests.Columns["PasswordReset"].Index && e.RowIndex >= 0)
                {
                    DataGridViewCheckBoxCell checkboxCell = dgv_pass_requests.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                    bool isChecked = (bool)checkboxCell.Value;

                    if (isChecked)
                    {
                        checkedRows--;
                    }
                    else
                    {
                        checkedRows++;
                    }

                    txt_no_of_checked_box.Text = checkedRows.ToString();
                }
            }
            catch(System.InvalidCastException)
            {
                TostMessage tostMessage = new TostMessage("Empty Rows Can not be Selected","Warrning",1,1);
                tostMessage.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerHome managerHome = new ManagerHome();
            this.Hide();
            managerHome.Show();
        }

        private void chbx_check_all_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
