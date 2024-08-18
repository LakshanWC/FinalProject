using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Sales_Finance;
using FinalProject.three_tier_architecture.BLL.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    public partial class Transaction : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            BTransaction request = new BTransaction();
            loadGridViewData(request.getPaymentPanding(false));
        }

        private void loadGridViewData(DataSet results)
        {
            if ( results.Tables[0].Rows.Count == 0)
            {
                TostMessage messFaild = new TostMessage("No items requiring payment were found.", "Warning",1,1);
                messFaild.Show();
            }
            else if (results != null)
            {
                dgv_requests.DataSource = results.Tables[0];
            }
            else if(results == null)
            {
                TostMessage messFaild = new TostMessage("No items requiring payment were found.", "Warning", 1, 1);
                messFaild.Show();
            }
        }

        private void dgv_requests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the clicked row index is valid
                if (e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgv_requests.Rows[e.RowIndex];

                    // Get values from the selected row
                    string reqId = selectedRow.Cells["ReqID"].Value.ToString();
                    int reqQuantity = Convert.ToInt32(selectedRow.Cells["ReqQuantity"].Value);
                    string priceStr = selectedRow.Cells["price"].Value.ToString();
                    decimal price = Convert.ToDecimal(priceStr);

                    // Set the text of textboxes
                    txt_selected_row.Text = "Item " + reqId;
                    txt_requested_quantity.Text = reqQuantity.ToString();
                    txt_net_total.Text = price.ToString(); // Assuming you want to format it as currency
                }
            }
            catch (Exception ex) 
            {
                txt_net_total.Clear();
                MessageBox.Show("Please select a valied row", 
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_mark_as_paid_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_selected_row.Text))
            {


                string text = txt_selected_row.Text;
                string reqId = text.Split(' ')[1];
                BTransaction markAsPaid = new BTransaction();

                int stat = markAsPaid.setAsPaid(reqId);
                if (stat > 0)
                {
                    BTransaction request = new BTransaction();
                    dgv_requests.DataSource = null;
                    loadGridViewData(request.getPaymentPanding(false));
                    clearUi();
                    TostMessage messSucc = new TostMessage("Item successfully marked as paid.", "Success", 3, 3);
                    messSucc.Show();
                }
                else if (stat == 0)
                {
                    clearUi();
                    TostMessage messFaild = new TostMessage("Failed to mark item as paid. Please try again.", "Warning", 1, 1);
                    messFaild.Show();
                }
                else if (stat == -1)
                {
                    clearUi();
                    TostMessage messUnexpeted = new TostMessage("Unexpected Error", "Error", 2, 2);
                    messUnexpeted.Show();
                }
            }
            else
            {
                MessageBox.Show("No Item has been Selected","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void clearUi()
        {
            txt_selected_row.Clear();
            txt_requested_quantity.Clear();
            txt_net_total.Clear();
        }

        private void btn_load_all_paided_Click(object sender, EventArgs e)
        {
            btn_mark_as_paid.Enabled = false;

            dgv_requests.DataSource = null;
            BTransaction request = new BTransaction();
            loadGridViewData(request.getAllPaid());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_mark_as_paid.Enabled = true;

            dgv_requests.DataSource = null;
            BTransaction request = new BTransaction();
            loadGridViewData(request.getPaymentPanding(false));
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
            NewManagerHome.opendChildForms.Remove("Transaction");
            this.Dispose();
        }
    }
}
