using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL;
using FinalProject.three_tier_architecture.BLL.Chef;
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
    public partial class UpdateInventory : Form
    {
        public UpdateInventory()
        {
            InitializeComponent();
        }

        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            BUpdateInventory getNames = new BUpdateInventory();
            DataSet stockNames = new DataSet();
            stockNames = getNames.getStockNames();
            cmb_selected_item.Items.Add("--Select--");

            DataTable tbl = stockNames.Tables[0];
            foreach (DataRow row in tbl.Rows)
            {
                cmb_selected_item.Items.Add(row[0].ToString());
            }
            cmb_selected_item.SelectedIndex = 0;
        }

        private void cmb_selected_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_selected_item.SelectedIndex >0)
            {
                BUpdateInventory stock = new BUpdateInventory();
                DataSet stockDetails = stock.getStockDetails(cmb_selected_item.SelectedItem.ToString());

                if (stockDetails != null)
                {

                    DataTable dt = stockDetails.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        txt_quantity.Text = Convert.ToString(row["Inquantity"]);
                        cmb_status.SelectedItem = row["inStatus"].ToString();
                    }
                }
            }
            else
            {
                clearUi();
            }
        }

        private void clearUi()
        {
            txt_quantity.Clear();
            nud_quntity.Value = 0;
            cmb_selected_item.SelectedIndex = 0;
        }

        private void btn_update_status_Click(object sender, EventArgs e)
        {
            if(nud_quntity.Value == 0 && cmb_selected_item.SelectedIndex != 0)
            {
                DialogResult results = MessageBox.Show("You are about to set the remaining quantity to 0. Are you sure you want to proceed?",
                    "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (results == DialogResult.Yes)
                {
                   updateStocks();
                }
            }
            else if(cmb_selected_item.SelectedIndex != 0)
            {
                updateStocks();
            }
            else
            {
                MessageBox.Show("Please Select an Item First","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void updateStocks()
        {
            BUpdateInventory updatedData = new BUpdateInventory();
            int stat = updatedData.updateStockDetails(cmb_selected_item.SelectedItem.ToString(),
                Convert.ToInt32(nud_quntity.Value), cmb_status.SelectedItem.ToString());

            if (stat > 0)
            {
                TostMessage messSucc = new TostMessage("Stock Updated Successfuly!", "Successful", 3, 3);
                messSucc.Show();
                clearUi();
            }
            else if (stat == 0)
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void nud_quntity_ValueChanged(object sender, EventArgs e)
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
