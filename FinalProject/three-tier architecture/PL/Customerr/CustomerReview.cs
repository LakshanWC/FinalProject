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
    public partial class CustomerReview : Form
    {
        public CustomerReview()
        {
            InitializeComponent();
        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            if(count > 0 && count == 500)
            {
                count = txt_description.Text.Length;
                lbl_no_of_letters.Text = $"{count}/500";
            }
            else if(txt_description.Text.Length == 500)
            {
               // txt_description.Text = txt_description.Text.Substring(0, 10);
               // txt_description.SelectionStart = txt_description.Text.Length; //
            }

        }

        private void txt_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }
    }
}
