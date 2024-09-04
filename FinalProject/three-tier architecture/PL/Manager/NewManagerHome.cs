using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using FinalProject.MVC.View;
using FinalProject.MVC.Control;
using FinalProject.MVC;
using FinalProject.three_tier_architecture.PL.Manager;
using CrystalDecisions.Windows.Forms;
using FinalProject.three_tier_architecture.BLL.Sales_Finance;
using System.Windows.Forms.DataVisualization.Charting;
using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System.Drawing.Printing;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class NewManagerHome : Form
    {
        public NewManagerHome()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        private int cusSatisfactionTarget;
        private int stockTarget;
        public static List<string> opendChildForms = new List<string>();


        public void setUserName(string userName)
        {
            lbl_userName.Text = userName;
        }

        private void myInit()
        {
            timer.Interval = 10;
            timer.Tick += new EventHandler(this.Timer_Tick);

            // target values for progress bars
          //  cusSatisfactionTarget = 60; // target value

            // progress bar Start values
            cpb_cutomer_satisfaction.Value = 0;
            cpb_stock_prisentage.Value = 0;

            DStockUi stocks = new DStockUi();
            BManagerHome_All mang = new BManagerHome_All();
            double score = stocks.getPresentage("All");
            int cusScore = mang.getCustomerSatis();

            if (score > 0 && cusScore > 0)
            {
                stockTarget = (int)score; // Assign progressScore
                cusSatisfactionTarget =(int)cusScore;
                timer.Interval = 10; // Set interval 
                timer.Tick += new EventHandler(this.Timer_Tick);
                timer.Start(); // Start the timer
            }
            else if (score == -1 && cusScore == -1)
            {
                // exception
                cpb_stock_prisentage.Text = "N/A";
                cpb_cutomer_satisfaction.Text = "N/A";
            }
            else if (score == 0 && cusScore == 0)
            {
                // Not found
                cpb_stock_prisentage.Value = 0;
                cpb_cutomer_satisfaction.Value = 0;
            }

            // Start the timer
            timer.Start();


            BManagerHome_All home = new BManagerHome_All();
            int noOfRequests = home.getPasswordResetRequests();
            lbl_no_of_pass_reset.Text = Convert.ToString(noOfRequests);

            if (noOfRequests > 0)
            {

                TostMessage myTost = new TostMessage("Password Reset Requests Available. " +
                    "Please check and accept them", "Notification", 1, 1);
                myTost.Show();

            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gradually decrease the progress bar values
            if (cpb_cutomer_satisfaction.Value < cusSatisfactionTarget)
            {
                cpb_cutomer_satisfaction.Value += 1;
                cpb_cutomer_satisfaction.Text = cpb_cutomer_satisfaction.Value.ToString() + "%";
            }

            if (cpb_stock_prisentage.Value < stockTarget)
            {
                cpb_stock_prisentage.Value += 1;
                cpb_stock_prisentage.Text = cpb_stock_prisentage.Value.ToString() + "%";
            }

            // Stop the timer when both progress bars reach their target values
            if (cpb_cutomer_satisfaction.Value >= cusSatisfactionTarget && cpb_stock_prisentage.Value >= stockTarget)
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

        private void setManagerHomeData()
        {
            BManagerHome_All manHome = new BManagerHome_All();
            lbl_no_of_employee.Text = Convert.ToString(manHome.noOfEmployees());
            lbl_total_earning.Text = "LRK."+Convert.ToString(manHome.getIncome());
            chart();
            setEvents(manHome.getEvents());
        }

        private void setEvents(DataSet ds)
        {
            if(ds != null)
            {
                DataTable dataTable = ds.Tables[0];
                foreach (DataRow row in dataTable.Rows)
                {
                    lbl_event_title.Text = row["Ename"].ToString();
                    int eventStat = Convert.ToInt32(row["Estatus"]);
                    if (eventStat == 0)
                    {
                        lbl_event_status.Text = "Scheduled";
                    }
                    else if (eventStat == 1)
                    {
                        lbl_event_status.Text ="Ongoing";
                    }


                    lbl_event_start_time.Text = row["EstartTime"].ToString();
                }
            }
        }

        private void NewManagerHome_Load(object sender, EventArgs e)
        {
            btn_home.PerformClick();
            myInit();
            setManagerHomeData();
        }

        private void pnl_side_panle_Paint(object sender, PaintEventArgs e)
        {
           // this.BackColor = Color.FromArgb(00, 00, 00);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_home.Height;
            pnl_nav.Top = btn_home.Top;
            pnl_nav.Left = btn_home.Left;
            btn_home.BackColor = Color.FromArgb(30,30,30);

            foreach (var child in this.MdiChildren)
            {
                child.Close();
                
            }
            opendChildForms.Clear();
            tlp_dash_board.Visible = true;
        }

        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_home.BackColor = Color.FromArgb(42,42,42);
        }

        private void cpb_stock_prisentage_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_enable_password_Click(object sender, EventArgs e)
        {
           
            pnl_nav.Height =  btn_enable_password.Height;
            pnl_nav.Top =  btn_enable_password.Top;
            pnl_nav.Left =  btn_enable_password.Left;
            btn_enable_password.BackColor = Color.FromArgb(30, 30, 30);
            PasswordRequest request = new PasswordRequest();

            if (!opendChildForms.Contains("passRequest") && opendChildForms.Count <= 2)
            {
                this.tlp_dash_board.Visible = false;
                

                request.MdiParent = this;
                request.Show();

                opendChildForms.Add("passRequest");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            pnl_nav.Height =  btn_add_employee.Height;
            pnl_nav.Top =  btn_add_employee.Top;
            pnl_nav.Left =  btn_add_employee.Left;
            btn_add_employee.BackColor = Color.FromArgb(30, 30, 30);

            if (!opendChildForms.Contains("addEmployee") && opendChildForms.Count <= 2)
            {
                this.tlp_dash_board.Visible = false;
                AddEmployee emp = new AddEmployee();
                emp.MdiParent = this;
                emp.Show();

                opendChildForms.Add("addEmployee");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_add_menu_item_Click(object sender, EventArgs e)
        {
            pnl_nav.Height =  btn_add_menu_item.Height;
            pnl_nav.Top =  btn_add_menu_item.Top;
            pnl_nav.Left =  btn_add_menu_item.Left;
            btn_add_menu_item.BackColor = Color.FromArgb(30, 30, 30);

            if (!opendChildForms.Contains("addItem") && opendChildForms.Count <= 2)
            {
                this.tlp_dash_board.Visible = false;
                AddItem itme = new AddItem();
                itme.MdiParent = this;
                itme.Show();

                opendChildForms.Add("addItem");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }


        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            Login logout = new Login();
            this.Hide();
            logout.Show();
        }

        private void btn_enable_password_Leave(object sender, EventArgs e)
        {
            btn_enable_password.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void btn_add_employee_Leave(object sender, EventArgs e)
        {
            btn_add_employee.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void btn_add_menu_item_Leave(object sender, EventArgs e)
        {
            btn_add_menu_item.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void addMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opendChildForms.Contains("addItem") && opendChildForms.Count <= 2)
            {
                this.tlp_dash_board.Visible = false;
                AddItem itme = new AddItem();
                itme.MdiParent = this;
                itme.Show();

                opendChildForms.Add("addItem");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opendChildForms.Contains("Event") && opendChildForms.Count <= 2)
            {
                this.tlp_dash_board.Visible = false;
                Event addEvent = new Event();
                addEvent.MdiParent = this;
                addEvent.Show();

                opendChildForms.Add("Event");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void attendentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReportUi reports = new GenerateReportUi();
            GenerateReportUi.reportType = 0;
            reports.Show();
        }

        private void overAllIncomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReportUi reports = new GenerateReportUi();
            GenerateReportUi.reportType = 1;
            reports.Show();
        }

        private void attendentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opendChildForms.Contains("Attendents") && opendChildForms.Count <= 2)
            {
                this.tlp_dash_board.Visible = false;
                Attendents emp = new Attendents();
                emp.MdiParent = this;
                emp.Show();

                opendChildForms.Add("Attendents");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opendChildForms.Contains("RemoveEmployee") && opendChildForms.Count <= 2)
            {
                this.tlp_dash_board.Visible = false;
                RemoveEmployee emp = new RemoveEmployee();
                emp.MdiParent = this;
                emp.Show();

                opendChildForms.Add("RemoveEmployee");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void removeMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opendChildForms.Contains("RemoveMenuItem") && opendChildForms.Count <= 2)
            {
                this.tlp_dash_board.Visible = false;
                RemoveMenuItem emp = new RemoveMenuItem();
                emp.MdiParent = this;
                emp.Show();

                opendChildForms.Add("RemoveMenuItem");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }
    }
}
