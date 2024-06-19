using FinalProject.three_tier_architecture;
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
        private int count = 0;

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
            if (!string.IsNullOrEmpty(txt_item_description.Text) && !string.IsNullOrEmpty(txt_item_name.Text)
                && !string.IsNullOrEmpty(txt_item_id.Text) && !string.IsNullOrEmpty(txt_item_price.Text))
            {







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
            icon = foodIcon.getItemImage(count);
            pb_item_image.Image = icon;
            cmb_item_type.SelectedIndex = 0;
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (count >=9) 
            {
                count = 0;
                icon = foodIcon.getItemImage(count);
                pb_item_image.Image = icon;
                cmb_item_type.SelectedIndex = 0;  
            }
            else
            {
                count++;
                icon = foodIcon.getItemImage(count);
                pb_item_image.Image = icon;

                if (count >= 7 && count <= 9)
                {
                    cmb_item_type.SelectedIndex = 1;
                }
                else cmb_item_type.SelectedIndex = 0;
            }
        }

        private void btn_backward_Click(object sender, EventArgs e)
        {
            if (count <= 0)
            {
                icon = foodIcon.getItemImage(count);
                pb_item_image.Image = icon;
                count = 0;
                cmb_item_type.SelectedIndex= 0 ;
            }
            else
            {
                count--;
                icon = foodIcon.getItemImage(count);
                pb_item_image.Image = icon;

                if (count >= 0 && count <= 6)
                {
                    cmb_item_type.SelectedIndex = 0;
                }
            }
        }
    }
}
