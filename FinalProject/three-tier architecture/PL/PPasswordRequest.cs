using FinalProject.MVC.Control;
using FinalProject.MVC.Model;
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
    public partial class PPasswordRequest : Form
    {
        public PPasswordRequest()
        {
            InitializeComponent();
        }

        private void PasswordRequest_Load(object sender, EventArgs e)
        {
            BPassResetRequests passRsetObj = new BPassResetRequests();
            InitializeCheckedRowsCount();
            DataSet ds = passRsetObj.getPassRequests();

            if(ds.Tables.Count > 0 )
            {
                dgv_pass_requests.DataSource = ds.Tables[0];
            }
           
        }

        private void dgv_pass_requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
                int checkedRows = 0; // Moved declaration inside the event handler

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                    dgv_pass_requests.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell)
                {
                    bool isChecked = (bool)dgv_pass_requests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (isChecked)
                    {
                        checkedRows--;
                    }
                    else
                    {
                        checkedRows++;
                    }

                    txt_no_of_checked_box.Text = Convert.ToString(checkedRows);
                }*/
        }

        // TostMessage tostMessage = new TostMessage("Empty Rows Can not be Selected", "Warrning", 1, 1);
        //tostMessage.Show();

        private void button2_Click(object sender, EventArgs e)
        {
            PManagerHome managerHome = new PManagerHome();
            this.Hide();
            managerHome.Show();
        }

        private void chbx_check_all_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chbx_check_all.Checked;

            foreach (DataGridViewRow row in dgv_pass_requests.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["PasswordReset"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    checkBoxCell.Value = isChecked;
                }
            }
        }

        private int checkedRows = 0;

        private void dgv_pass_requests_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                dgv_pass_requests.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell)
            {
                bool isChecked = (bool)dgv_pass_requests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (isChecked)
                {
                    checkedRows++;
                }
                else
                {
                    checkedRows--;
                }

                txt_no_of_checked_box.Text = Convert.ToString(checkedRows);
            }
        }

        private void dgv_pass_requests_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_pass_requests.IsCurrentCellDirty)
            {
                dgv_pass_requests.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void InitializeCheckedRowsCount()
        {
            checkedRows = 0;
            foreach (DataGridViewRow row in dgv_pass_requests.Rows)
            {
                if (row.Cells["PasswordReset"] is DataGridViewCheckBoxCell checkBoxCell &&
                    checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    checkedRows++;
                }
            }
            txt_no_of_checked_box.Text = checkedRows.ToString();
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            BPassResetRequests myPass = new BPassResetRequests();
            List<int> selectedValues = new List<int>();
            try
            {
                foreach (DataGridViewRow row in dgv_pass_requests.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["PasswordReset"].Value);

                    if (isChecked)
                    {
                        int uridValue = Convert.ToInt32(row.Cells["URid"].Value);
                        selectedValues.Add(uridValue);
                    }
                }
            } catch (InvalidCastException ex)
            {
                foreach (DataGridViewRow row in dgv_pass_requests.Rows)
                {
                    row.Cells["PasswordReset"].Value = false;

                }
                checkedRows = 0;
                txt_no_of_checked_box.Text = checkedRows.ToString();
            }

            DResetPassword rePass = new DResetPassword();

           // if (chbx_check_all.Checked == true) rePass.setNewPasssword(selectedValues, 1);
           // else rePass.setNewPasssword(selectedValues, 0);




            /*

            List<int> selectedRowIds = new List<int>();
            foreach (DataGridViewRow row in dgv_pass_requests.Rows)
            {
                if (row.Selected)
                {
                    selectedRowIds.Add(Convert.ToInt32(row.Cells["URid"].Value));
                }
            }

            int affectedRowCount = myPass.updateSelectedRows(selectedRowIds);

            if (affectedRowCount > 0)
            {
                int selectedRowCountChange = selectedRowIds.Count - affectedRowCount;

                checkedRows += selectedRowCountChange;

                txt_no_of_checked_box.Text = checkedRows.ToString();

                TostMessage myToast = new TostMessage("New Passwords Activated", "Success", 3, 3);
                myToast.Show();
            }
            else
            {
                TostMessage myToast = new TostMessage("Failed to activate passwords", "Error", 3, 3);
                myToast.Show();
            }*/
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            PPasswordRequest myReq = new PPasswordRequest();
            myReq.PasswordRequest_Load(null, EventArgs.Empty);
        }

    }
}

