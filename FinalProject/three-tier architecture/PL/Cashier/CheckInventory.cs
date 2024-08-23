using FinalProject.three_tier_architecture.BLL.Sales_Finance;
using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using FinalProject.three_tier_architecture.PL.Supplier;
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

namespace FinalProject.three_tier_architecture.PL.Cashier
{
    public partial class CheckInventory : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        Timer timer = new Timer();
        int progressScore = 0;

        public CheckInventory()
        {
            InitializeComponent();
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

        private void CheckInventory_Load(object sender, EventArgs e)
        {
            loadCmbItems();
            chart();
            cpb_stock_prisentage.Value = 0;
            cmb_stock_names.SelectedIndex = 0;
            DStockUi stocks = new DStockUi();
            double score = stocks.getPresentage(cmb_stock_names.SelectedItem.ToString());

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
            BStockUi stocks = new BStockUi();
            DataSet names = stocks.getStockData();

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
                        var series = new Series(row["InName"].ToString())
                        {
                            ChartType = SeriesChartType.Column // Use Column chart for vertical bars
                        };

                        // Add a data point to the series
                        series.Points.AddXY(counter, Convert.ToDouble(row["Inquantity"]));

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
            BStockUi names = new BStockUi();
            DataSet data = names.getStockData();
            DataTable tbl = data.Tables[0];

            cmb_stock_names.Items.Clear();
            cmb_stock_names.Items.Add("All");

            foreach (DataRow row in tbl.Rows)
            {
                cmb_stock_names.Items.Add(row["InName"].ToString());
            }

            cmb_stock_names.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            NewManagerHome.opendChildForms.Remove("CheckInventory");
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
