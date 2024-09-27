using FinalProject.three_tier_architecture.DAL.Chef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Chef
{
    public partial class FeedBack : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public FeedBack()
        {
            InitializeComponent();
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {
            cmb_selected_item.SelectedIndex = 0;
        }

        private void btn_update_status_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_message.Text))
            {
                DFeedBack feed = new DFeedBack();
                feed.setFeedBack(cmb_selected_item.SelectedItem.ToString(),txt_message.Text);
                txt_message.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a message before Adding the feedback.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("FeedBack");
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
