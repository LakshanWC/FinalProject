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
    public partial class AddNewStock : Form
    {
        public AddNewStock()
        {
            InitializeComponent();
        }

        private void btn_add_new_stock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_item_no_one.Text))
            {
                BAddNewStock stock = new BAddNewStock();
                int isDone = stock.addnewStock(txt_item_no_one.Text, Convert.ToInt32(nud_quntity.Value));

                if (isDone == 1)
                {
                    TostMessage messSucc = new TostMessage("Stock Added Successfuly!", "Successful", 3, 3);
                    messSucc.Show();
                    setCmbItems();
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
                    MessageBox.Show("Stock name exists. Select it from the list to change details.", "Warning",
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
    }
}
