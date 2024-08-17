using FinalProject.MVC;
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
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            BTransaction request = new BTransaction();
            loadGridViewData(request.getPaymentPanding(false));
            cb_loadAll.Checked = false;
        }

        private void loadGridViewData(DataSet results)
        {
            if (cb_loadAll.Checked == false && results.Tables[0].Rows.Count == 0)
            {
                TostMessage messFaild = new TostMessage("No deliveries found for today.", "Warning", 1, 1);
                messFaild.Show();

            }
            else if (cb_loadAll.Checked == true && results.Tables[0].Rows.Count == 0)
            {
                TostMessage messFaild = new TostMessage("No deliveries found.", "Warning", 1, 1);
                messFaild.Show();

            }
            else if (results != null)
            {
                dgv_requests.DataSource = results.Tables[0];
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
    }
}
