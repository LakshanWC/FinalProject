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

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            BTrackDelivery deliveryOrders = new BTrackDelivery();
            DataSet orders = deliveryOrders.getDeliveryOrders(txt_order_id.Text);

            if (orders == null || orders.Tables.Count == 0 || orders.Tables[0].Rows.Count == 0)
            {
                // Show a message when no orders are found
                TostMessage messFailed = new TostMessage("No Orders Were Found!", "Failed", 1, 1);
                return;
            }

            DataTable normalOrders = orders.Tables[0];

            foreach (DataRow row in normalOrders.Rows)
            {
                // Check if the UniqeKey column exists & notNull
                string hasOrder = row["OrderStatus"].ToString();
                cmb_located_Order.Items.Add(row["UniqeKey"].ToString());
                cmb_located_Order.SelectedIndex = 0;

                if (hasOrder != null)
                {
                   setUiImages(hasOrder);
                }
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
    }
}
