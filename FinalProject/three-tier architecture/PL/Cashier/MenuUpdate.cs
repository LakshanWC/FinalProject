using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Cashier;
using FinalProject.three_tier_architecture.BLL.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Cashier
{
    public partial class MenuUpdate : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        private DataSet menuData;
        ItemImage getImage = new ItemImage();
        BFoodMenu menu = new BFoodMenu();

        private string itemId;
        private Image iconOne;
        private int btnPressedCount = 0;

        public MenuUpdate()
        {
            InitializeComponent();
        }

        private void MenuUpdate_Load(object sender, EventArgs e)
        {
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

            }
            else
            {
                // if no tables in the DataSet
                TostMessage msg = new TostMessage("No Item found!", "Faild", 2, 2);
                msg.Show();
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_item_cal_one.Text) && !string.IsNullOrEmpty(txt_item_price_one.Text))
            {

                string itemName = txt_item_name_one.Text;
                string itemPrice = txt_item_price_one.Text;
                string itemCalori = txt_item_cal_one.Text;

                BMenuUpdate menu = new BMenuUpdate();
                int stat = menu.updateMenuItem(itemName, itemPrice, itemCalori);

                if (stat == 0)
                {
                    TostMessage messFail = new TostMessage("Failed to Update the Item","Warning",1,1);
                    messFail.Show();
                }
                else if(stat > 0)
                {
                    TostMessage messSucc = new TostMessage("Updated Successfully", "Successful", 2, 2);
                    messSucc.Show();
                }
                else if( stat == -1)
                {
                    TostMessage messUnExpect = new TostMessage("UnExpected Error", "Error", 3, 3);
                    messUnExpect.Show();
                }

            }
            else
            {
                MessageBox.Show("Please Enter price & calories","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("MenuUpdate");
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
