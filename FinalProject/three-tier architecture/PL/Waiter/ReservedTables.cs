using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Waiter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Waiter
{
    public partial class ReservedTables : Form
    {

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public ReservedTables()
        {
            InitializeComponent();
        }

        private void ReservedTables_Load(object sender, EventArgs e)
        {
            BReservedTables resTBl = new BReservedTables();
            loadToDataGrid(resTBl.getTables());

        }

        //load dataset to dataGrid view
        private void loadToDataGrid(DataSet results)
        {
            // Make sure dataSet is not null
            if (results != null && results.Tables.Count > 0)
            {
                // Set the DataSource of the DataGridView to the first DataTable in the DataSet
                dgv_reservedTables.DataSource = results.Tables[0];

                // set Auto-generate as true
                dgv_reservedTables.AutoGenerateColumns = true;
            }
            else
            {
                dgv_reservedTables.DataSource = null;
                TostMessage messFaild = new TostMessage("No Orders Were Found", "Faild", 1, 1);
                messFaild.Show();
            }
        }

        private void btn_update_status_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_selected_item.Text))
            {
                BReservedTables resTbl = new BReservedTables();
                int stat = resTbl.markTable(txt_selected_item.Text,cmb_Order_status.SelectedItem.ToString());

                if (stat > 0)
                {
                    TostMessage messSucc = new TostMessage("Marked Successfuly!", "Successful", 3, 3);
                    messSucc.Show();
                    txt_selected_item.Clear();
                    BReservedTables resTBl = new BReservedTables();
                    loadToDataGrid(resTBl.getTables());
                }
                else if (stat == 0)
                {
                    TostMessage messFaild = new TostMessage("Marking Faild", "Faild", 1, 1);
                    messFaild.Show();
                    txt_selected_item.Clear();
                }
                else
                {
                    TostMessage messUnexpected = new TostMessage("Unexpected Error", "Error", 2, 2);
                    messUnexpected.Show();
                    txt_selected_item.Clear();
                }
            }
        }

        private void dgv_reservedTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgv_reservedTables.Rows[e.RowIndex];
                string reqId = selectedRow.Cells["Tid"].Value.ToString();
                txt_selected_item.Text = reqId;
            }
            catch (System.InvalidCastException)
            {
                MessageBox.Show("Selected Row Is not Valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selected Row Is not Valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Add("ReservedTables");
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
