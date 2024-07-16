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
        public OrderFood()
        {
            InitializeComponent();
        }

        private void OrderFood_Load(object sender, EventArgs e)
        {
            txt_loyal_card_tel_no.Enabled = false;
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
    }
}
