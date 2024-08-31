using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Supplier;
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
    public partial class AddOT : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public AddOT()
        {
            InitializeComponent();
        }

        private void AddOT_Load(object sender, EventArgs e)
        {
            BAddOt bAddOt = new BAddOt();
            setUserNames(bAddOt.getUserNames());
        }

        public void setUserNames(DataSet ds)
        {
            if(ds != null)
            {
                DataTable dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    cmb_user_names.Items.Add(row["Eusername"].ToString());
                }
                cmb_user_names.SelectedIndex = 0;
            }
            else
            {
                TostMessage messFail = new TostMessage("No Employees were found!","Warning",1,1);
                messFail.Show();
            }

        }

        private void cmb_user_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            BAddOt overTime = new BAddOt();
            setUiData(overTime.getUserDetails(cmb_user_names.SelectedItem.ToString()));
        }

        private void setUiData(DataSet ds)
        {
            DataTable dt = ds.Tables[0];
            foreach(DataRow row in dt.Rows)
            {
                txt_user_name.Text = row["Eusername"].ToString();
                txt_empType.Text = getSelectedEmployeeValue(Convert.ToInt32(row["Etype"]));
                nud_otHours.DecimalPlaces = 2;
                nud_otHours.Value = Convert.ToDecimal(row["OtHours"]);
            }
        }

        private string getSelectedEmployeeValue(int selectedValue)
        {
            switch (selectedValue)
            {
                case 2:
                    return "Manager"; //manager type =2
                    break;
                case 3:
                    return "Chef"; //chef type = 3
                    break;
                case 4:
                    return "Cashier"; //cashier =4
                    break;
                case 5:
                    return "Delivery"; //delivery team = 5
                    break;
                case 6:
                    return "Sales & Finance"; //sales & finance = 6
                    break;
                case 8:
                    return "Waiter";//waiter = 8
                case 9:
                    return "supplier";//supplier = 9
                default:
                    return "non";
                    break;
            }
        }

        private void btn_update_details_Click(object sender, EventArgs e)
        {
            BAddOt overTime = new BAddOt();
            bool isDone = overTime.setOT(nud_otHours.Value, cmb_user_names.SelectedItem.ToString());
            if (isDone)
            {
                TostMessage messSucc = new TostMessage("OT Hours Add", "Succsess", 3, 3);
                messSucc.Show();
            }
            else
            {
                TostMessage messFail = new TostMessage("Failed to Add OT Hours", "Failed", 1, 1);
                messFail.Show();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("Add OT");
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
