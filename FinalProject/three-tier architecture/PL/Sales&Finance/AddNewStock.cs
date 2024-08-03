using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    public partial class AddNewStock : Form
    {
        public AddNewStock()
        {
            InitializeComponent();
        }

        private void btn_add_new_stock_Click(object sender, EventArgs e)
        {

        }

        private void AddNewStock_Load(object sender, EventArgs e)
        {
            setCmbStatus();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            setCmbStatus();
        }

        private void setCmbStatus()
        {
            if (nud_quntity.Value == 0)
            {
                //out of stock
                cmb_status.SelectedIndex = 1;
            }
            else if (nud_quntity.Value <= 10)
            {
                //low on stock
                cmb_status.SelectedIndex = 2;
            }
            else if (nud_quntity.Value == 100 || nud_quntity.Value >10)
            {
                //in stock
                cmb_status.SelectedIndex = 3;
            }
        }
    }
}
