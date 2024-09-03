using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Cashier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Cashier
{
    public partial class Complaints : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private int currentRowIndex = 0;
        private DataTable dt;

        public Complaints()
        {
            InitializeComponent();
        }

        private void Complaints_Load(object sender, EventArgs e)
        {
            getData();
            LoadData(currentRowIndex);
        }

        private void getData()
        {
            BComplaints comp = new BComplaints();
            DataSet ds = new DataSet();
            ds = comp.getAllComplaints();

            dt = ds.Tables[0];
        }

        private void LoadData(int rowIndex)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[rowIndex];
                txt_tableNO.Text = dr["tableNo"].ToString();
                txt_reqType.Text = dr["requestType"].ToString();
                txt_description.Text = dr["requestDetails"].ToString();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentRowIndex < dt.Rows.Count - 1)
            {
                currentRowIndex++;
                LoadData(currentRowIndex);
            }
            else
            {
                TostMessage tosMess = new TostMessage("You are at the last record.", "Information",1,1);
                tosMess.Show();
            }
        }

        private void btn_pervios_Click(object sender, EventArgs e)
        {
            if (currentRowIndex > 0)
            {
                currentRowIndex--;
                LoadData(currentRowIndex);
            }
            else
            {
                TostMessage tostMessage = new TostMessage("You are at the first record.", "Information",1,1);
                tostMessage.Show();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("Complaints");
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
