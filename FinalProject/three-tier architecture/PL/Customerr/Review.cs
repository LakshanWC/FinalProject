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
    public partial class Review : Form
    {
        private int count = 0;
        private int btnYesPressed = 0;
        private int btnNoPressed = 0;

        public Review()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if (btnYesPressed == 0)
            {
                count++;
                no_of_people.Text = count.ToString();
            }
            else
            {
                
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if(count > 0 && btnNoPressed == 0)
            {
                count--;
                no_of_people.Text = count.ToString();
            }
            
        }
    }
}
