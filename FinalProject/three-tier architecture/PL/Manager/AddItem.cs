using FinalProject.three_tier_architecture;
using FinalProject.three_tier_architecture.BLL;
using FinalProject.three_tier_architecture.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.MVC.View
{
    public partial class AddItem : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private ItemImage foodIcon = new ItemImage();
        private Image icon;
        private int imageNo = 0;
     

        //data from the ui
        private int itemId ;
        private string itemName;
        private double itemPrice;
        private int itemType;
        private int itemCalories;
        private string itemDescription;


        public AddItem()
        {
            InitializeComponent();
        }

        private void txt_item_description_TextChanged(object sender, EventArgs e)
        {   
            int count = 0;
            count = txt_item_description.Text.Length;
            lbl_word_count.Text = $"{count}/500";
        }

        private void txt_item_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (txt_item_description.Text.Length >= 500)
            {
                e.Handled = true; 
            }
        }

        private void txt_add_item_Click(object sender, EventArgs e)
        {
            //set values
            itemId = Convert.ToInt32(txt_item_id.Text);
            itemName = txt_item_name.Text;
            itemCalories = Convert.ToInt32(txt_calories.Text);
            itemType = cmb_item_type.SelectedIndex;
            itemPrice = Convert.ToDouble(txt_item_price.Text);
            itemDescription = txt_item_description.Text;

            if (!string.IsNullOrEmpty(txt_item_description.Text) && !string.IsNullOrEmpty(txt_item_name.Text)
                && !string.IsNullOrEmpty(txt_item_id.Text) && !string.IsNullOrEmpty(txt_item_price.Text))
            {

                BAddItem addItem = new BAddItem();
                int status = addItem.addItem(itemName, itemPrice, itemType, itemCalories, itemDescription, imageNo);

                if (status == 1) {
                    TostMessage messageSucses = new TostMessage("Item Successfully added", "Successful", 3, 3);
                    messageSucses.Show();
                    clearUi();
                }
                else if (status == 0) {
                    TostMessage messageFail = new TostMessage("Item adding failed", "Failed", 1, 1);
                    messageFail.Show();
                    clearUi();

                }
                else {
                    TostMessage messageError = new TostMessage("Unexpected Error Occurred", "Unexpected Error", 2, 2);
                    messageError.Show();
                    clearUi();
                }

            }
            
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("addItem");
            this.Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            icon = foodIcon.getItemImage(imageNo);
            pb_item_image.Image = icon;
            cmb_item_type.SelectedIndex = 0;

            BAddItem itemId = new BAddItem();
            txt_item_id.Text = Convert.ToString("0"+itemId.getItemId());

        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (imageNo >=9) 
            {
                imageNo = 0;
                icon = foodIcon.getItemImage(imageNo);
                pb_item_image.Image = icon;
                cmb_item_type.SelectedIndex = 0;  
            }
            else
            {
                imageNo++;
                icon = foodIcon.getItemImage(imageNo);
                pb_item_image.Image = icon;

                if (imageNo >= 7 && imageNo <= 9)
                {
                    cmb_item_type.SelectedIndex = 1;
                }
                else cmb_item_type.SelectedIndex = 0;
            }
        }

        private void btn_backward_Click(object sender, EventArgs e)
        {
            if (imageNo <= 0)
            {
                icon = foodIcon.getItemImage(imageNo);
                pb_item_image.Image = icon;
                imageNo = 0;
                cmb_item_type.SelectedIndex= 0 ;
            }
            else
            {
                imageNo--;
                icon = foodIcon.getItemImage(imageNo);
                pb_item_image.Image = icon;

                if (imageNo >= 0 && imageNo <= 6)
                {
                    cmb_item_type.SelectedIndex = 0;
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearUi();
        }
        private void clearUi() 
        {
            //Clear data from ui
            txt_item_name.Clear();
            txt_calories.Clear();
            txt_item_price.Clear();
            txt_item_description.Clear();
        }
    }
}
