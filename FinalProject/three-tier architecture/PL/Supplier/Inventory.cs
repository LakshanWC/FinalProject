using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Sales_Finance;
using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using FinalProject.three_tier_architecture.DAL.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace FinalProject.three_tier_architecture.PL.Supplier
{
    public partial class Inventory : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        Timer timer = new Timer();
        int progressScore = 0;

        public Inventory()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("Inventory");
            this.Close();
        }

        private void cmb_stock_names_SelectedIndexChanged(object sender, EventArgs e)
        {

            cpb_stock_prisentage.Value = 0;
            DStockUi stocks = new DStockUi();
            double score = stocks.getPresentage(cmb_stock_names.SelectedItem.ToString());


            if (score > 0)
            {
                progressScore = (int)score; // Assign progressScore
                timer.Interval = 10; // Set interval 
                timer.Tick += new EventHandler(this.Timer_Tick);
                timer.Start(); // Start timer
            }
            else if (score == -1)
            {
                // exception
                cpb_stock_prisentage.Text = "N/A";
            }
            else if (score == 0)
            {
                // Not found
                cpb_stock_prisentage.Value = 0;
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            loadCmbItems();
            chart();
            cpb_stock_prisentage.Value = 0;
            cmb_stock_names.SelectedIndex = 0;
            DInventory stocks = new DInventory();
            double score = stocks.getPercentage(cmb_stock_names.SelectedItem.ToString());

            if (score > 0)
            {
                progressScore = (int)score; // Assign progressScore
                timer.Interval = 10; // Set interval 
                timer.Tick += new EventHandler(this.Timer_Tick);
                timer.Start(); // Start the timer
            }
            else if (score == -1)
            {
                // exception
                cpb_stock_prisentage.Text = "N/A";
            }
            else if (score == 0)
            {
                // Not found
                cpb_stock_prisentage.Value = 0;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (cpb_stock_prisentage.Value < progressScore)
            {
                cpb_stock_prisentage.Value += 1;
                cpb_stock_prisentage.Text = cpb_stock_prisentage.Value.ToString() + "%";
            }
            else if (cpb_stock_prisentage.Value >= progressScore)
            {
                timer.Stop();
            }
        }

        private void chart()
        {
            DInventory stocks = new DInventory();
            DataSet names = stocks.getInventoryItems();

            if (names != null && names.Tables.Count > 0)
            {
                DataTable tbl = names.Tables[0];

                if (tbl.Rows.Count > 0)
                {
                    // Clear existing series 
                    ch_stocks.Series.Clear();

                    int counter = 1; // Initialize a counter

                    foreach (DataRow row in tbl.Rows)
                    {
                        // Create a new series with the counter as the name
                        var series = new Series(row["itemName"].ToString())
                        {
                            ChartType = SeriesChartType.Column // Use Column chart for vertical bars
                        };

                        // Add a data point to the series
                        series.Points.AddXY(counter, Convert.ToDouble(row["iQuantity"]));

                        // Add the series to the chart
                        ch_stocks.Series.Add(series);

                        counter++; // Increment the counter
                    }
                }
                else
                {
                    MessageBox.Show("No data available to display.");
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve data.");
            }
        }

        private void loadCmbItems()
        {
            DInventory names = new DInventory();
            DataSet data = names.getInventoryItems();
            DataTable tbl = data.Tables[0];

            cmb_stock_names.Items.Clear();
            cmb_stock_names.Items.Add("All");

            foreach (DataRow row in tbl.Rows)
            {
                cmb_stock_names.Items.Add(row["itemName"].ToString());
                cmb_selected_item.Items.Add(row["itemName"].ToString());
            }

            cmb_stock_names.SelectedIndex = 0;
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

        private void btn_update_status_Click(object sender, EventArgs e)
        {
            DInventory dInvent = new DInventory();
            string itemName = cmb_selected_item.SelectedItem.ToString();
            int stat = dInvent.updateInventoryItem(itemName,Convert.ToInt32(nud_quntity.Value),txt_item_Name.Text);

            if (stat == 0)
            {
                TostMessage ErrorTost = new TostMessage("Item Updating Faild", "Faild", 1, 1);
                ErrorTost.Show();
                clearUi();
            }
            else if (stat == 1)
            {
                TostMessage SuccTost = new TostMessage("Item Updated", "Success", 3, 3);
                SuccTost.Show();
                clearUi();
            }
            else
            {
                TostMessage ExepTost = new TostMessage("UnExpected Error", "Error", 2, 2);
                ExepTost.Show();
                clearUi();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_item_Name.Text;
            int quantitiy = Convert.ToInt32(nud_quntity.Value);

            if (!string.IsNullOrEmpty(name))
            {

                DInventory dInventory = new DInventory();
                int stat = dInventory.setInventoryItem(name, quantitiy);

                if (stat == 0)
                {
                    TostMessage ErrorTost = new TostMessage("Item Adding Faild", "Faild", 1, 1);
                    ErrorTost.Show();
                    clearUi();
                }
                else if (stat == 1)
                {
                    TostMessage SuccTost = new TostMessage("Item Added", "Success", 3, 3);
                    SuccTost.Show();
                    clearUi();
                }
                else
                {
                    TostMessage ExepTost = new TostMessage("UnExpected Error", "Error", 2, 2);
                    ExepTost.Show();
                    clearUi();
                }
            }
            else
            {
                MessageBox.Show("Name Can not be empty");
            }
           
        }

        //dont touch this
        private void setCmbStatus()
        {
            if (Convert.ToInt32(txt_quantity.Text) == 0)
            {
                //out of stock
                cmb_status.SelectedIndex = 1;
            }
            else if (Convert.ToInt32(txt_quantity.Text) <= 10)
            {
                //low on stock
                cmb_status.SelectedIndex = 2;
            }
            else if (Convert.ToInt32(txt_quantity.Text) == 100 || Convert.ToInt32(txt_quantity.Text) >10)
            {
                //in stock
                cmb_status.SelectedIndex = 3;
            }
        }

        private void cmb_selected_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            DInventory dInv = new DInventory();
            DataSet ds = new DataSet();
            string name = cmb_selected_item.SelectedItem.ToString();

            // Assuming getSelectedItem returns a DataSet with the desired data
            ds = dInv.getSelectedItem(name);
            DataTable dt = ds.Tables[0]; // Get the first DataTable from the DataSet

            if (dt.Rows.Count > 0)
            {
                // Assuming you only want the first row
                DataRow row = dt.Rows[0];
                txt_item_Name.Text = row["itemName"].ToString();
                txt_quantity.Text = row["iQuantity"].ToString();
            }
        }

        private void nud_quntity_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            setCmbStatus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            DInventory dInventory = new DInventory();
            if (!string.IsNullOrEmpty(txt_item_Name.Text))
            {
                int stat = dInventory.deleteInventoryItem(txt_item_Name.Text);

                if (stat == 0)
                {
                    TostMessage ErrorTost = new TostMessage("Item Deleting Faild", "Faild", 1, 1);
                    ErrorTost.Show();
                    clearUi();
                }
                else if (stat == 1)
                {
                    TostMessage SuccTost = new TostMessage("Item Deleted", "Success", 3, 3);
                    SuccTost.Show();
                    clearUi();
                }
                else
                {
                    TostMessage ExepTost = new TostMessage("UnExpected Error", "Error", 2, 2);
                    ExepTost.Show();
                    clearUi();
                }
            }
        }

        private void clearUi()
        {
            txt_item_Name.Clear();
            txt_quantity.Text = "0";
            nud_quntity.Value = 0;
        }
    }
}
