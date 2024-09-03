using FinalProject.MVC.Control;
using FinalProject.MVC.Model;
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

namespace FinalProject.MVC.View
{
    public partial class PasswordRequest : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public PasswordRequest()
        {
            InitializeComponent();
        }

        private void PasswordRequest_Load(object sender, EventArgs e)
        {
            BPassResetRequests pass = new BPassResetRequests();
            loadToDataGrid(pass.getPassRequests());
        }

        //load dataset to dataGrid view
        private void loadToDataGrid(DataSet results)
        {
            // Make sure dataSet is not null
            if (results != null && results.Tables.Count > 0)
            {
                // Set the DataSource of the DataGridView to the first DataTable in the DataSet
                dgv_pass_requests.DataSource = results.Tables[0];

                // set Auto-generate as true
                dgv_pass_requests.AutoGenerateColumns = true;
            }
            else
            {
                dgv_pass_requests.DataSource = null;
                TostMessage messFaild = new TostMessage("No Orders Were Found", "Faild", 1, 1);
                messFaild.Show();
            }
        }

        private void dgv_pass_requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewManagerHome managerHome = new NewManagerHome();
            this.Hide();
            managerHome.Show();
        }

        private void chbx_check_all_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dgv_pass_requests_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_pass_requests_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
        }

        private void PasswordRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("passRequest");
            this.Dispose();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("passRequest");
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

        private void dgv_pass_requests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgv_pass_requests.Rows[e.RowIndex];
                string reqId = selectedRow.Cells["Eid"].Value.ToString();
                txt_no_of_checked_box.Text= reqId;
                

            }
            catch (System.InvalidCastException)
            {
                MessageBox.Show("Selected Row Is not Valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selected Row Is not Valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_enable_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_no_of_checked_box.Text))
            {
                BPassResetRequests passReq = new BPassResetRequests();
                bool isDone = passReq.setNewPassword(txt_no_of_checked_box.Text);

                if (isDone)
                {
                    TostMessage mesSuc = new TostMessage("Password Changed", "Successful",3,3);
                    mesSuc.Show();
                }
                else
                {
                    TostMessage messFail = new TostMessage("Changing Faild", "Warning", 1, 2);
                    messFail.Show();
                }
            }
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            BPassResetRequests pass = new BPassResetRequests();
            loadToDataGrid(pass.getPassRequests());
        }
    }
}

