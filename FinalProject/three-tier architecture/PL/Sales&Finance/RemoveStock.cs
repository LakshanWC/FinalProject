using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL;
using FinalProject.three_tier_architecture.BLL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Sales_Finance
{
    public partial class RemoveStock : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public RemoveStock()
        {
            InitializeComponent();
        }

        private void RemoveStock_Load(object sender, EventArgs e)
        {
            BRemoveStock names = new BRemoveStock();
            DataSet data = names.getStockNames();
            DataTable dt = data.Tables[0];

            foreach(DataRow row in dt.Rows)
            {
                cmb_stock_names.Items.Add(row["InName"].ToString());
            }
            cmb_stock_names.SelectedIndex = 0;
        }

        private void clearUi()
        {
            txt_stock_name.Clear();
            txt_quntity.Text = "0";
        }

        private void setCmbStatus()
        {
            if (Convert.ToInt32(txt_quntity.Text) == 0)
            {
                //out of stock
                cmb_status.SelectedIndex = 1;
            }
            else if (Convert.ToInt32(txt_quntity.Text) <= 10)
            {
                //low on stock
                cmb_status.SelectedIndex = 2;
            }
            else if (Convert.ToInt32(txt_quntity.Text) == 100 || Convert.ToInt32(txt_quntity.Text) >10)
            {
                //in stock
                cmb_status.SelectedIndex = 3;
            }
        }

        private void cmb_stock_names_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_stock_names.SelectedIndex >0)
            {
               setCmbNames();
            }
            else
            {
                clearUi();
            }
        }

        private void setCmbNames()
        {
            if (cmb_stock_names.SelectedIndex >0)
            {

                BRemoveStock stocks = new BRemoveStock();
                DataSet details = stocks.getStockDetails(cmb_stock_names.SelectedItem.ToString());

                if (details != null)
                {

                    DataTable dt = details.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        txt_stock_name.Text = row["InName"].ToString();
                        txt_quntity.Text = Convert.ToString(row["Inquantity"]);
                        cmb_stock_names.SelectedItem = row["inStatus"].ToString();
                    }
                }
            }
        }

        private void btn_update_details_Click(object sender, EventArgs e)
        {
            if(cmb_stock_names.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid Name","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BRemoveStock remove = new BRemoveStock();
                int status = remove.removeStock(cmb_stock_names.SelectedItem.ToString());

                if(status > 0)
                {
                    TostMessage messSucc = new TostMessage("Stock Removed Successfuly!", "Successful", 3, 3);
                    messSucc.Show();

                    //clear & set the first cmbBox item
                    cmb_stock_names.Items.Clear();
                    cmb_stock_names.Items.Add("-- Select to search --");

                    setCmbNames();
                    cmb_stock_names.SelectedIndex = 0;
                    clearUi();
                }
                if(status == 0)
                {
                    TostMessage messFaild = new TostMessage("Stock Removeing Faild", "Faild", 1, 1);
                    messFaild.Show();
                }
                else if (status == -1)
                {
                    TostMessage messUnexpected = new TostMessage("Unexpected Error", "Error", 2, 2);
                    messUnexpected.Show();
                }
            }
        }

        private void nud_quntity_ValueChanged(object sender, EventArgs e)
        {
            
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
            NewManagerHome.opendChildForms.Remove("Remove Stock");
            this.Close();
        }

        private void txt_quntity_TextChanged(object sender, EventArgs e)
        {
            setCmbStatus();
        }
    }
}
