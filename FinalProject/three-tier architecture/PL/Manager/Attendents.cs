using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Manager
{
    public partial class Attendents : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Attendents()
        {
            InitializeComponent();
        }

        private void Attendents_Load(object sender, EventArgs e)
        {
            cmb_filter_type.SelectedIndex = 0;
        }

        private void setDataGridView(DataSet results)
        {
            // Make sure dataSet is not null
            if (results != null && results.Tables.Count > 0)
            {
                // Set the DataSource of the DataGridView to the first DataTable in the DataSet
                dgv_attendents.DataSource = results.Tables[0];

                // set Auto-generate as true
                dgv_attendents.AutoGenerateColumns = true;
            }
            else
            {
                dgv_attendents.DataSource = null;
                TostMessage messFaild = new TostMessage("No Orders Were Found", "Faild", 1, 1);
                messFaild.Show();
            }
        }

        private void cmb_filter_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            BAttendents attendents = new BAttendents();
            DataSet dataSet = new DataSet();
            dataSet = attendents.getAttendents(cmb_filter_type.SelectedItem.ToString());
            setDataGridView(dataSet);
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
            NewManagerHome.opendChildForms.Remove("Attendents");
            this.Dispose();
        }
    }
}
