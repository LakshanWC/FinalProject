using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Delivery_Team;
using FinalProject.three_tier_architecture.PL.Customerr;
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
        string reqId;
        bool acceptedOrder = false;
        string itemName;
        string orderType;

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
            acceptedOrder = false ;
            dgv_orders.DataSource = null;

            BDelivery deliverSpcOrder = new BDelivery();
            DataSet ds = new DataSet();
            ds = deliverSpcOrder.getSpecialOrders();

            loadToDataGrid(ds);
        }

        private void btn_normal_orders_Click(object sender, EventArgs e)
        {
            acceptedOrder = false ;
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
            try
            {
                DataGridViewRow selectedRow = dgv_orders.Rows[e.RowIndex];


                if (dgv_orders.Columns.Contains("SORdetails"))
                {
                    isItNormalOrder = false;
                    
                    reqId = selectedRow.Cells["SORid"].Value.ToString();
                    txt_selected_item.Text = reqId;
                    itemName = selectedRow.Cells["itemName"].Value.ToString();


                    cmb_Order_status.SelectedIndex = 0;
                }
                else if(dgv_orders.Columns.Contains("orderId"))
                {
                    reqId = selectedRow.Cells["orderId"].Value.ToString();
                    txt_selected_item.Text = reqId;
                    itemName = selectedRow.Cells["itemName"].Value.ToString();

                    orderType = selectedRow.Cells["orderType"].Value.ToString();

                    if (orderType == "Normal")
                    {
                        isItNormalOrder = true;
                    }
                    else
                    {
                        isItNormalOrder = false;
                    }

                    cmb_Order_status.SelectedIndex = 1;
                }
                else
                {
                    isItNormalOrder = true;

                    reqId = selectedRow.Cells["UniqeKey"].Value.ToString();
                    txt_selected_item.Text = reqId;
                    itemName = selectedRow.Cells["ItemName"].Value.ToString();


                    cmb_Order_status.SelectedIndex = 0;
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

        private void btn_update_status_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_selected_item.Text))
            {
                BDelivery delivery = new BDelivery();

                if (acceptedOrder == true)
                {
                    bool stat = delivery.setDeliveryLog(DeliveryTeamHome.userNameDelivery,reqId,itemName,cmb_Order_status.SelectedItem.ToString(),isItNormalOrder);
                    delivery.updateDeliveryTemp(reqId, itemName, isItNormalOrder, cmb_Order_status.SelectedItem.ToString());
                    clearUi();

                    if (stat)
                    {
                        TostMessage mesSucc = new TostMessage("Marked Successfully", "Success", 3, 3);
                        mesSucc.Show();
                        clearUi();
                    }
                    else
                    {
                        TostMessage messFail = new TostMessage("Marking Faild!", "Warning", 1, 1);
                        messFail.Show();
                        clearUi();
                    }
                }
                else
                {

                    int stat = delivery.updateDeliveryStatus(reqId, itemName, isItNormalOrder, cmb_Order_status.SelectedItem.ToString());

                    if (stat == 0)
                    {
                        TostMessage messFail = new TostMessage("Marking Faild!", "Warning", 1, 1);
                        messFail.Show();
                        clearUi();
                    }
                    else if (stat > 0)
                    {
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
            }
        }

        private void clearUi()
        {
            txt_selected_item.Clear();
        }

        private void btn_accsepted_orders_Click(object sender, EventArgs e)
        {
            acceptedOrder = true;
            BDelivery deliverTeam = new BDelivery();
            loadToDataGrid(deliverTeam.getAcceptedDelivery());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Add("Delivery");
            this.Dispose();
        }

        private void cmb_Order_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
