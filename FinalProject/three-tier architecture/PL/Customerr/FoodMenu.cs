using FinalProject.MVC;
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
    public partial class FoodMenu : Form
    {
        private DataSet menuData;
        ItemImage getImage = new ItemImage();
        BFoodMenu menu = new BFoodMenu();
        private List<string> selectedItems = new List<string>();
        private string itemId;
        private Image iconOne ;
        private int btnPressedCount = 0;

        public FoodMenu()
        {
            InitializeComponent();
        }

        private void txt_review_score_one_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_item_cal_one_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_item_price_one_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_item_no_one_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_select_item_one_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_select_item_one.Checked)
            {
                nud_item_one_quantity.Minimum = 1;
                nud_item_one_quantity.Enabled = true;
                nud_item_one_quantity.Value = 1;
                AddSelectedItem(itemId);
            }
            else
            {
                nud_item_one_quantity.Minimum = 0;
                nud_item_one_quantity.Value = 0;
                nud_item_one_quantity.Enabled = false;
                RemoveSelectedItem(itemId);
            }

        }

        private void cb_selecte_item_two_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            nud_item_one_quantity.Minimum = 0;
            nud_item_one_quantity.Value = 0;
            nud_item_one_quantity.Enabled =false;

            DisplayMenuItems(menu, ref btnPressedCount);
            lbl_page_no.Text = Convert.ToString(btnPressedCount+1 +"/"+getRowCount(menu));
        }

        public void DisplayMenuItems(BFoodMenu menu, ref int btnPressedCount)
        {
            // Retrieve menu items
            DataSet menuData = menu.getMenuItems();

            if (menuData.Tables.Count > 0)
            {
                DataTable table = menuData.Tables[0];
                int maxRows = table.Rows.Count;

                // Check if btnPressedCount is within bounds
                if (btnPressedCount < 0 || btnPressedCount >= maxRows)
                {
                    // Reset to 0 if out of bounds
                    btnPressedCount = 0;
                }

                // Display data for valid btnPressedCount
                DataRow row = table.Rows[btnPressedCount];
                itemId = row["itemID"].ToString();


                txt_item_name_one.Text = row["itemName"].ToString();
                txt_item_price_one.Text = row["itemPrice"].ToString();
                txt_item_cal_one.Text = row["itemCalories"].ToString();

                //retrieves images
                iconOne = getImage.getItemImage(Convert.ToInt32(row["itemImageNo"]));
                pb_item_one.Image = iconOne;

                // Update checkbox state
                cb_select_item_one.CheckedChanged -= cb_select_item_one_CheckedChanged; // Temporarily remove event handler
                cb_select_item_one.Checked = selectedItems.Contains(itemId);
                cb_select_item_one.CheckedChanged += cb_select_item_one_CheckedChanged; // Re-add event handler

            }
            else
            {
                // if no tables in the DataSet
                TostMessage msg = new TostMessage("No Item found!", "Faild", 2, 2);
                msg.Show();
            }
        }

        private void AddSelectedItem(string itemId)
        {
            if (!selectedItems.Contains(itemId))
            {
                selectedItems.Add(itemId);
            }
        }
        private void RemoveSelectedItem(string itemId)
        {
            if (selectedItems.Contains(itemId))
            {
                selectedItems.Remove(itemId);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            btnPressedCount++;
            DisplayMenuItems(menu, ref btnPressedCount);
            lbl_page_no.Text = Convert.ToString(btnPressedCount+1 +"/"+getRowCount(menu));
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {

            btnPressedCount--;
            DisplayMenuItems(menu, ref btnPressedCount);
            lbl_page_no.Text = Convert.ToString(btnPressedCount+1 +"/"+getRowCount(menu));
        }

        //get row count of the dataset
        public int getRowCount(BFoodMenu menu)
        {
            // Retrieve menu items
            DataSet menuData = menu.getMenuItems();

            // Check if the DataSet contains any tables
            if (menuData.Tables.Count > 0)
            {
                // Get the first DataTable from the DataSet
                DataTable table = menuData.Tables[0];

                // Return the number of rows in table
                return table.Rows.Count;
            }
            else
            {
                Console.WriteLine("No data available.");
                return 0;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("FoodMenu");
            this.Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

        }

    }
}
