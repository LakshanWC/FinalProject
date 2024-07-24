using FinalProject.three_tier_architecture.BLL.Customer;
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
    public partial class OrderFood : Form
    {
        private Image itemImage;

        public OrderFood()
        {
            InitializeComponent();
        }

        private void OrderFood_Load(object sender, EventArgs e)
        {
            txt_loyal_card_tel_no.Enabled = false;
        }

        public void setSelectedItemsToCB (List<string> selectedItems)
        {
            foreach (string item in selectedItems) 
            {
                cmb_selected_item.Items.Add(item);
            }
            cmb_selected_item.SelectedIndex = 0;
        }

        private void rbtn_loyal_yes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_loyal_yes.Checked)
            {
                txt_loyal_card_tel_no.Enabled=true;
            }
        }

        private void rbtn_loyal_no_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_loyal_no.Checked)
            {
                txt_loyal_card_tel_no.Enabled=false;
            }
        }

        private void cmb_selected_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            BOrderFood data = new BOrderFood();
            DataSet results = new DataSet();
            results = data.getItemData(cmb_selected_item.SelectedItem.ToString());

            if (results != null)
            {
                setUIData(results);
            }
        }

        public void setUIData(DataSet data)
        {
            DataTable table = data.Tables[0];
            ItemImage getImage = new ItemImage();

            for(int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                itemImage = getImage.getItemImage(Convert.ToInt32(row["itemImageNo"]));
                pb_item_image.Image = itemImage;

                txt_item_name.Text = row["itemName"].ToString();
                txt_item_price.Text = row["itemPrice"].ToString();
                txt_item_cal.Text = row["itemCalories"].ToString();
            }

        }
    }
}
