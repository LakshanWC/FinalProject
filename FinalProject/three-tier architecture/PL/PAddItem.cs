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
    public partial class PAddItem : Form
    {
        public PAddItem()
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
                && !string.IsNullOrEmpty(txt_item_id.Text) && !string.IsNullOrEmpty(txt_item_price.Text)
                && nud_item_quantity.Value > 0)
            {







            }
            
        }
    }
}
