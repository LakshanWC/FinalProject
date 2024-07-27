using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class OrderCustomize : Form
    {
        public OrderCustomize()
        {
            InitializeComponent();
        }

        private void OrderCustomize_Load(object sender, EventArgs e)
        {
            //select this if there is an item
            if(cmb_selected_item.Items.Count > 0)
            {
                cmb_selected_item.SelectedIndex = 0;
            }
        }

        //set Ui data
        public void passData(string orderId,string selectedOrder,string itemName,string price,Image itemImage)
        {
            txt_order_id.Text = orderId;
            cmb_selected_item.Items.Add(selectedOrder);
            txt_item_name.Text = itemName;
            txt_price.Text = price;
            pb_item_one.Image = itemImage;
            

        }

    }
}
