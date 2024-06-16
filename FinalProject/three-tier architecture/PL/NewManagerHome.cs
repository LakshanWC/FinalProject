using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class NewManagerHome : Form
    {
        public NewManagerHome()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        private int cusSatisfactionTarget;
        private int stockTarget;

        private void myInit()
        {
            timer.Interval = 10;
            timer.Tick += new EventHandler(this.Timer_Tick);

            // target values for progress bars
            cusSatisfactionTarget = 60; // target value
            stockTarget = 50; // target value

            // progress bar Start values
            cpb_cutomer_satisfaction.Value = 0;
            cpb_stock_prisentage.Value = 0;

            // Start the timer
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gradually decrease the progress bar values
            if (cpb_cutomer_satisfaction.Value < cusSatisfactionTarget)
            {
                cpb_cutomer_satisfaction.Value += 1;
                cpb_cutomer_satisfaction.Text = cpb_cutomer_satisfaction.Value.ToString() + "%";
            }

            if (cpb_stock_prisentage.Value < stockTarget)
            {
                cpb_stock_prisentage.Value += 1;
                cpb_stock_prisentage.Text = cpb_stock_prisentage.Value.ToString() + "%";
            }

            // Stop the timer when both progress bars reach their target values
            if (cpb_cutomer_satisfaction.Value >= cusSatisfactionTarget && cpb_stock_prisentage.Value >= stockTarget)
            {
                timer.Stop();
            }
        }

        private void NewManagerHome_Load(object sender, EventArgs e)
        {
            btn_dashboard.PerformClick();
            myInit();
        }

        private void pnl_side_panle_Paint(object sender, PaintEventArgs e)
        {
           // this.BackColor = Color.FromArgb(00, 00, 00);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_dashboard.Height;
            pnl_nav.Top = btn_dashboard.Top;
            pnl_nav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(30,30,30);

        }

        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(42,42,42);
        }

        private void cpb_stock_prisentage_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
           
            pnl_nav.Height = btn_logout.Height;
            pnl_nav.Top = btn_logout.Top;
            pnl_nav.Left = btn_logout.Left;
            btn_logout.BackColor = Color.FromArgb(30, 30, 30);
        }
    }
}
