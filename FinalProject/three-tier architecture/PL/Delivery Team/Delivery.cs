using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Delivery_Team;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Delivery_Team
{
    public partial class Delivery : Form
    {
        bool isItNormalOrder = false;

        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            BDelivery delivery = new BDelivery();
            DataSet ds = new DataSet();
            ds = delivery.getOrders();

            loadToDataGrid(ds);
        }

        private void btn_special_Order_delivery_Click(object sender, EventArgs e)
        {
            dgv_orders.DataSource = null;

            BDelivery deliverSpcOrder = new BDelivery();
            DataSet ds = new DataSet();
            ds = deliverSpcOrder.getSpecialOrders();

            loadToDataGrid(ds);
        }

        private void btn_normal_orders_Click(object sender, EventArgs e)
        {
            dgv_orders.DataSource = null;

            BDelivery deliverSpcOrder = new BDelivery();
            DataSet ds = new DataSet();
            ds = deliverSpcOrder.getOrders();

            loadToDataGrid(ds);

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
                TostMessage messFaild = new TostMessage("No Orders Were Found", "Faild", 1, 1);
                messFaild.Show();
            }
        }

        private void dgv_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string reqId;
            string reqStat;

            try
            {
                DataGridViewRow selectedRow = dgv_orders.Rows[e.RowIndex];


                if (dgv_orders.Columns.Contains("SORdetails"))
                {
                    isItNormalOrder = false;
                    
                    reqId = selectedRow.Cells["SORid"].Value.ToString();
                    txt_selected_item.Text = reqId;
                    reqStat = selectedRow.Cells["orderStat"].Value.ToString();
                }
                else
                {
                    isItNormalOrder = true;

                    reqId = selectedRow.Cells["UniqeKey"].Value.ToString();
                    txt_selected_item.Text = reqId;
                    reqStat = selectedRow.Cells["OrderStatus"].Value.ToString();
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
            catch (System.ArgumentException)
            {
                MessageBox.Show("Not a Valid Order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
