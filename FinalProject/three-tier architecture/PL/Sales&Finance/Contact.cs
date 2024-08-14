using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Sales_Finance;
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
    public partial class Contact : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private DateTime requestDate = DateTime.Now;

        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            dtp_deliver_on_date.MinDate = DateTime.Now;

            BContact contact = new BContact();
            DataSet ds = new DataSet();
            ds = contact.getStockNames();

            cmb_stock_names.Items.Clear();
            cmb_stock_names.Items.Add("-- Select --");

            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                cmb_stock_names.Items.Add(row[0].ToString());
            }

            cmb_stock_names.SelectedIndex = 0;
        }

        private void btn_add_new_stock_Click(object sender, EventArgs e)
        {
            if (nud_quntity.Value > 0 && cmb_stock_names.SelectedIndex != 0)
            {
                string inName = cmb_stock_names.SelectedItem.ToString();
                int reqQuantity = Convert.ToInt32(nud_quntity.Value);
                string description = txt_requset_description.Text;
                string requestStatus = "Requested";
                DateTime deliveryOn = dtp_deliver_on_date.Value;

                BContact request = new BContact();
                int result = request.setRequest(inName, reqQuantity, requestDate, description,
                    requestStatus, deliveryOn);

                if (result == 0)
                {
                    clearUi();
                    TostMessage mesFaild = new TostMessage("Request Adding Faild!", "Faild", 1, 1);
                    mesFaild.Show();
                }
                else if (result > 0)
                {
                    clearUi();
                    TostMessage messSucc = new TostMessage("Request Added Successfully", "Successful", 3, 3);
                    messSucc.Show();
                }
                else if (result == -1)
                {
                    clearUi();
                    TostMessage messUnexpeted = new TostMessage("Unexpected Error", "Error", 2, 2);
                    messUnexpeted.Show();
                }
            }
            else if(cmb_stock_names.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a stock","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearUi()
        {
            cmb_stock_names.SelectedIndex = 0;
            nud_quntity.Value = 0;
            dtp_deliver_on_date.Value = DateTime.Now;
            txt_requset_description.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("Contact");
            this.Close();
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
