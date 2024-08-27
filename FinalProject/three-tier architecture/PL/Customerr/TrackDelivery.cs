using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Customer;
using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class TrackDelivery : Form
    {
        public TrackDelivery()
        {
            InitializeComponent();
        }

        private void TrackDelivery_Load(object sender, EventArgs e)
        {
            cmb_order_type.SelectedIndex = 0;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_order_id.Text))
            {
                BTrackDelivery deliveryOrders = new BTrackDelivery();

                bool isNormal = false;
                if (cmb_order_type.SelectedIndex == 0) { isNormal = true; }
                else { isNormal = false; }

                DataSet orders = deliveryOrders.getDeliveryOrders(txt_order_id.Text, isNormal);

                if (orders == null || orders.Tables.Count == 0 || orders.Tables[0].Rows.Count == 0)
                {
                    // Show a message when no orders are found
                    TostMessage messFailed = new TostMessage("No Orders Were Found!", "Failed", 1, 1);
                    messFailed.Show();
                    return;
                }

                DataTable normalOrders = orders.Tables[0];

                foreach (DataRow row in normalOrders.Rows)
                {
                    // Check if the UniqeKey column exists & notNull
                    string uniqueKey = row["UniqeKey"].ToString();
                    string hasOrder = row["OrderStatus"].ToString();

                    // Check if the ComboBox already contains the item
                    if (!cmb_located_Order.Items.Contains(uniqueKey))
                    {
                        cmb_located_Order.Items.Add(uniqueKey);
                    }

                    cmb_located_Order.SelectedIndex = 0;

                }
            }
            else
            {
                MessageBox.Show("please enter Order id","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void setUiImages(string status)
        {
            Image pbImage = null;

            switch (status)
            {
                case "Standard Delivery":
                    //processing
                    break;
                case "Express Delivery":
                    //processing
                    pbImage = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\greenTick_logo.png");
                    pb_processing.Image = pbImage;
                    break;
                default:
                    //
                    break;
            }
        }

        private void cmb_located_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oid = cmb_located_Order.SelectedItem.ToString();
            BTrackDelivery delivery = new BTrackDelivery();
            string orderStatus = "";

            if (cmb_located_Order.SelectedIndex == 0)
            {
                 orderStatus = delivery.getOrderDeliverStat(oid,true);
            }
            else if(cmb_located_Order.SelectedIndex == 1)
            {
                 orderStatus = delivery.getOrderDeliverStat(oid, true);
            }

            setUi(orderStatus);
        }

        private void setUi(string status)
        {
            Image myImage = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\greenTick_logo.png");
            Image secondImage = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Ui-icons\\green_untick_logo.png");

            if (status == null)
            {
                //faild not found
                pb_processing.Image =secondImage;
                pb_on_the_way.Image = secondImage;
                pb_readyFor_delivery.Image = secondImage;
                pb_delivered.Image = secondImage;
            }
            else if(status =="Processing")
            {
                pb_processing.Image = myImage;
            }
            else if(status =="Ready For Delivery")
            {
                pb_processing.Image = myImage;
                pb_readyFor_delivery.Image = myImage;
            }
            else if(status =="On the Way")
            {
                pb_processing.Image = myImage;
                pb_readyFor_delivery.Image = myImage;
                pb_on_the_way.Image = myImage;
            }
            else if(status =="Delivered" || status == "Delivered(Payment Received)")
            {
                pb_processing.Image = myImage;
                pb_readyFor_delivery.Image = myImage;
                pb_on_the_way.Image = myImage;
                pb_delivered.Image = myImage;
            }
        }
    }
}
