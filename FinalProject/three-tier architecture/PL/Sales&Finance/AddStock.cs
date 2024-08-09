using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL;
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
    public partial class AddStock : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private string oldStockName;

        public AddStock()
        {
            InitializeComponent();
        }

        private void btn_add_new_stock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_item_no_one.Text))
            {
                BAddNewStock stock = new BAddNewStock();
                int isDone = stock.addnewStock(txt_item_no_one.Text, Convert.ToInt32(nud_quntity.Value),cmb_status.SelectedItem.ToString());

                if (isDone == 1)
                {
                    TostMessage messSucc = new TostMessage("Stock Added Successfuly!", "Successful", 3, 3);
                    messSucc.Show();
                    setCmbItems();
                    clearUi();
                }
                else if (isDone == 0)
                {
                    TostMessage messFaild = new TostMessage("Stock Adding Faild", "Faild", 1, 1);
                    messFaild.Show();
                }
                else if (isDone == -1)
                {
                    TostMessage messUnexpected = new TostMessage("Unexpected Error", "Error", 2, 2);
                    messUnexpected.Show();
                }
                else if (isDone == 2)
                {
                    MessageBox.Show("Stock name exists. Select it from the list & click update button to change details.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("please Fill out the details", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AddNewStock_Load(object sender, EventArgs e)
        {
            setCmbStatus();
            setCmbItems();
        }

        private void clearUi()
        {
            txt_item_no_one.Clear();
            nud_quntity.Value = 0;
        }

        private void setCmbItems()
        {
            BAddNewStock names = new BAddNewStock();
            DataSet data = names.getStockNames();

            DataTable dt = data.Tables[0];
            cmb_stock_names.Items.Clear();
            cmb_stock_names.Items.Add("--Select to search--");

            foreach (DataRow row in dt.Rows)
            {
                cmb_stock_names.Items.Add(row[0].ToString());
            }
           
            cmb_stock_names.SelectedIndex = 0;
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

        private void cmb_stock_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            oldStockName = cmb_stock_names.SelectedItem.ToString();

            if(cmb_stock_names.SelectedIndex >0)
            {
                BAddNewStock stock = new BAddNewStock();
                DataSet stockDetails = stock.getStockDetails(cmb_stock_names.SelectedItem.ToString());

                if (stockDetails != null)
                {

                    DataTable dt = stockDetails.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        txt_item_no_one.Text = row["InName"].ToString();
                        nud_quntity.Value = Convert.ToInt32(row["Inquantity"]);
                        cmb_stock_names.SelectedItem = row["inStatus"].ToString();
                    }
                }
            }
            else
            {
                clearUi();
            }
        }

        private void btn_update_details_Click(object sender, EventArgs e)
        {
            if(cmb_status.SelectedIndex >0 && !string.IsNullOrEmpty(txt_item_no_one.Text) && oldStockName !="--Select to search--")
            {
                BAddNewStock updatedData = new BAddNewStock();
                int stat = updatedData.updateStockDetails(txt_item_no_one.Text, Convert.ToInt32(nud_quntity.Value),
                    cmb_status.SelectedItem.ToString(),oldStockName);

                if (stat > 0)
                {
                    TostMessage messSucc = new TostMessage("Stock Updated Successfuly!", "Successful", 3, 3);
                    messSucc.Show();
                    clearUi();
                }
                else if(stat == 0)
                {
                    TostMessage messFaild = new TostMessage("Stock Updating Faild", "Faild", 1, 1);
                    messFaild.Show();
                    clearUi();
                }
                else
                {
                    TostMessage messUnexpected = new TostMessage("Unexpected Error", "Error", 2, 2);
                    messUnexpected.Show();
                    clearUi();
                }
            }
            else if(cmb_stock_names.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select a valied item name", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please Fill Out the details before Updating", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            NewManagerHome.opendChildForms.Remove("Add Stock");
            this.Close();
        }
    }
}
