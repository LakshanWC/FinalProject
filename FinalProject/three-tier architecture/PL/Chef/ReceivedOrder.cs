using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Chef;
using FinalProject.three_tier_architecture.DAL.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject.three_tier_architecture.PL.Chef
{
    public partial class ReceivedOrder : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        string reqId;
        bool isItNormalOrder = true;

        public ReceivedOrder()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReceivedOrder_Load(object sender, EventArgs e)
        {
            BReceivedOrder order = new BReceivedOrder();
            DataSet results = order.getOrders();
            loadToDataGrid(results);
            cmb_Order_status.SelectedIndex = 0;
        }

        //load dataset to dataGrid view
        private void loadToDataGrid(DataSet results)
        {
            // Make sure dataSet is not null
            if (results != null && results.Tables.Count > 0)
            {
                // Set the DataSource of the DataGridView to the first DataTable in the DataSet
                dgv_orders.DataSource = results.Tables[0];

                // set Auto-generate as true
                dgv_orders.AutoGenerateColumns = true;
            }
            else
            {
                dgv_orders.DataSource = null;
                TostMessage messFaild = new TostMessage("No Orders Were Found","Faild",1,1);
                messFaild.Show();
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            BReceivedOrder specOrder = new BReceivedOrder();
            DataSet specialOrders = specOrder.getSpecialOrders();
            loadToDataGrid(specialOrders);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BReceivedOrder order = new BReceivedOrder();
            DataSet results = order.getOrders();
            loadToDataGrid(results);
        }

        private void dgv_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgv_orders.Rows[e.RowIndex];
                reqId = selectedRow.Cells["UniqeKey"].Value.ToString();
                txt_selected_item.Text = reqId;
                string reqStat = selectedRow.Cells["OrderStatus"].Value.ToString();

                if (dgv_orders.Columns.Contains("SORdetails"))
                {
                    isItNormalOrder = false;
                }
                else
                {
                    isItNormalOrder = true;
                }

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

        private void btn_update_status_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_selected_item.Text))
            {
                BReceivedOrder update = new BReceivedOrder();
                int stat = update.updateOrderDeliveryStat(reqId, isItNormalOrder, cmb_Order_status.SelectedItem.ToString());

                if (stat == 0)
                {
                    TostMessage messFail = new TostMessage("Marking Faild!", "Warning", 1, 1);
                    messFail.Show();
                    clearUi();
                }
                else if (stat > 0)
                {
                    BReceivedOrder order = new BReceivedOrder();
                    DataSet results = order.getOrders();
                    loadToDataGrid(results);
                    cmb_Order_status.SelectedIndex = 0;

                    TostMessage mesSucc = new TostMessage("Marked Successfully", "Success", 3, 3);
                    mesSucc.Show();
                    clearUi();
                }
                else if (stat == -1)
                {
                    TostMessage messUnExpcted = new TostMessage("Unexpected Error", "Error", 2, 2);
                    messUnExpcted.Show();
                    clearUi();
                }
            }
            else
            {
                MessageBox.Show("Please Select an Order first!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearUi()
        {
            txt_selected_item.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("ReceivedOrder");
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
