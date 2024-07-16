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
            if(cb_select_item_one.Checked)
            {
                nud_item_one_quantity.Minimum = 1;
                nud_item_one_quantity.Enabled = true;
                nud_item_one_quantity.Value = 1;
            }
            if (cb_select_item_one.Checked == false) 
            {
                nud_item_one_quantity.Minimum = 0;
                nud_item_one_quantity.Value = 0;
                nud_item_one_quantity.Enabled = false;
            }

        }

        private void cb_selecte_item_two_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_selecte_item_two.Checked)
            {
                nud_item_two_quantity.Minimum = 1;
                nud_item_two_quantity.Enabled=true;
                nud_item_two_quantity.Value = 1;
            }
            if (cb_selecte_item_two.Checked == false)
            {
                nud_item_two_quantity.Minimum = 0;
                nud_item_two_quantity.Value = 0;
                nud_item_two_quantity.Enabled = false;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            nud_item_one_quantity.Minimum = 0;
            nud_item_two_quantity.Minimum = 0;
            nud_item_two_quantity.Value = 0;
            nud_item_one_quantity.Value = 0;
            nud_item_one_quantity.Enabled =false;
            nud_item_two_quantity.Enabled = false;

        }
    }
}
