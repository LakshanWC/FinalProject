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

namespace FinalProject.three_tier_architecture.PL.Supplier
{
    public partial class StockOrderRequest : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        Decimal netPrice;

        public StockOrderRequest()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("StockOrderRequests");
            this.Close();
        }

        private void StockOrderRequest_Load(object sender, EventArgs e)
        {
            BStockOrderRequest request = new BStockOrderRequest();
            loadGridViewData(request.getRequests(false));
            cb_loadAll.Checked = false;
        }

        private void loadGridViewData(DataSet results)
        {
            if(cb_loadAll.Checked == false && results.Tables[0].Rows.Count == 0)
            {
                TostMessage messFaild = new TostMessage("No deliveries found for today.", "Warning", 1, 1);
                messFaild.Show();

            }
            else if(cb_loadAll.Checked == true && results.Tables[0].Rows.Count == 0)
            {
                TostMessage messFaild = new TostMessage("No deliveries found.", "Warning", 1, 1);
                messFaild.Show();

            }
            else if(results != null)
            {
                dgv_requests.DataSource = results.Tables[0];
            }
        }

        private void cb_loadAll_CheckedChanged(object sender, EventArgs e)
        {
            BStockOrderRequest requests = new BStockOrderRequest();

            // Clear DataGridView 
            dgv_requests.DataSource = null;
            loadGridViewData(requests.getRequests(cb_loadAll.Checked));
        }

        private void dgv_requests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgv_requests.Rows[e.RowIndex];
                string reqId = selectedRow.Cells["ReqID"].Value.ToString();
                int reqQuantity = Convert.ToInt32(selectedRow.Cells["ReqQuantity"].Value);

                txt_selected_row.Text =  "Item "+reqId;
                txt_requested_quantity.Text = reqQuantity.ToString();
            }
            catch(System.InvalidCastException)
            {
                txt_requested_quantity.Text ="0";
                MessageBox.Show("Selected Row Is not Valid","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void nud_sigal_item_price_ValueChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_selected_row.Text) && txt_selected_row.Text !="Item "+"")
            {
                Decimal singlePrice = nud_sigal_item_price.Value;
                Decimal quantity = Convert.ToDecimal(txt_requested_quantity.Text);
                netPrice = singlePrice * quantity;

                txt_net_total.Text = netPrice.ToString();

            }
            else
            {
                nud_sigal_item_price.Value = 0;
                MessageBox.Show("Please selecte a Request First","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_set_net_price_Click(object sender, EventArgs e)
        {
            if (nud_sigal_item_price.Value != 0)
            {

                string text = txt_selected_row.Text; 
                string reqId = text.Split(' ')[1];   

                BStockOrderRequest priceUpdate = new BStockOrderRequest();
                int stat = priceUpdate.setPrice(netPrice, reqId);

                if (stat == 0)
                {
                    clearUi();
                    TostMessage mesFaild = new TostMessage("Price Updating Faild!", "Faild", 1, 1);
                    mesFaild.Show();
                }
                else if (stat > 0)
                {
                    loadGridViewData(priceUpdate.getRequests(cb_loadAll.Checked));
                    clearUi();
                    TostMessage messSucc = new TostMessage("Price Updated Successfully", "Successful", 3, 3);
                    messSucc.Show();
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
                MessageBox.Show("Please Enter a Price First","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = txt_selected_row.Text;
            string reqId = text.Split(' ')[1];


            BStockOrderRequest priceUpdate = new BStockOrderRequest();
            int stat = priceUpdate.setStat(reqId, "Out for Delivery");

            if (stat == 0)
            {
                clearUi();
                TostMessage mesFaild = new TostMessage("Status Updating Faild!", "Faild", 1, 1);
                mesFaild.Show();
            }
            else if (stat > 0)
            {
                loadGridViewData(priceUpdate.getRequests(cb_loadAll.Checked));
                clearUi();
                TostMessage messSucc = new TostMessage("Status Updated Successfully", "Successful", 3, 3);
                messSucc.Show();
            }
            else if (stat == -1)
            {
                clearUi();
                TostMessage messUnexpeted = new TostMessage("Unexpected Error", "Error", 2, 2);
                messUnexpeted.Show();
            }
        }

        private void btn_delivered_Click(object sender, EventArgs e)
        {
            string text = txt_selected_row.Text;
            string reqId = text.Split(' ')[1];


            BStockOrderRequest priceUpdate = new BStockOrderRequest();
            int stat = priceUpdate.setStat(reqId, "Delivered");

            if (stat == 0)
            {
                clearUi();
                TostMessage mesFaild = new TostMessage("Price Updating Faild!", "Faild", 1, 1);
                mesFaild.Show();
            }
            else if (stat > 0)
            {
                loadGridViewData(priceUpdate.getRequests(cb_loadAll.Checked));
                clearUi();
                TostMessage messSucc = new TostMessage("Price Updated Successfully", "Successful", 3, 3);
                messSucc.Show();
            }
            else if (stat == -1)
            {
                clearUi();
                TostMessage messUnexpeted = new TostMessage("Unexpected Error", "Error", 2, 2);
                messUnexpeted.Show();
            }
        }

        private void clearUi()
        { 
            nud_sigal_item_price.Value = 0;
            txt_net_total.Clear();
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

        private void dgv_requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
