using FinalProject.MVC.Model;
using FinalProject.three_tier_architecture.PL.Cashier;
using FinalProject.three_tier_architecture.PL.Chef;
using FinalProject.three_tier_architecture.PL.Customerr;
using FinalProject.three_tier_architecture.PL.Delivery_Team;
using FinalProject.three_tier_architecture.PL.Sales_Finance;
using FinalProject.three_tier_architecture.PL.Supplier;
using FinalProject.three_tier_architecture.PL.Waiter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class back_up_form : Form
    {
        public back_up_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // manager
            pnl_nav.Visible = true;
            pnl_nav.Height = button1.Height;
            pnl_nav.Top = button1.Top;
            pnl_nav.Left = button1.Left;

            NewManagerHome mHome = new NewManagerHome();
            mHome.setUserName("e000002");
            //this.Hide();
            mHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sales
            pnl_nav.Visible = true;
            pnl_nav.Height = button2.Height;
            pnl_nav.Top = button2.Top;
            pnl_nav.Left = button2.Left;

            SalesAndFinanceHome saleHome = new SalesAndFinanceHome();
            saleHome.setUserName("e000006");
            //this.Hide();
            saleHome.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Cahirer
            pnl_nav.Visible = true;
            pnl_nav.Height = button6.Height;
            pnl_nav.Top = button6.Top;
            pnl_nav.Left = button6.Left;

            CahierHome cashHo = new CahierHome();
            cashHo.setUserName("e000004");
          //  this.Hide();
            cashHo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Chef
            pnl_nav.Visible = true;
            pnl_nav.Height = button4.Height;
            pnl_nav.Top = button4.Top;
            pnl_nav.Left = button4.Left;

            ChefHome chfHom = new ChefHome();
            chfHom.setUserName("e000003");
            // this.Hide();
            chfHom.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //waiter
            pnl_nav.Visible = true;
            pnl_nav.Height = button7.Height;
            pnl_nav.Top = button7.Top;
            pnl_nav.Left = button7.Left;

            WaiterHome waitHome = new WaiterHome();
            waitHome.setUserName("e000007");
            //this.Hide();
            waitHome.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delivery
            pnl_nav.Visible = true;
            pnl_nav.Height = button3.Height;
            pnl_nav.Top = button3.Top;
            pnl_nav.Left = button3.Left;

            DeliveryTeamHome dTHome = new DeliveryTeamHome();
            dTHome.setUserName("e000005");
           // this.Hide();
            dTHome.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //customer
            pnl_nav.Visible = true;
            pnl_nav.Height = button5.Height;
            pnl_nav.Top = button5.Top;
            pnl_nav.Left = button5.Left;

            CustomerHome cusHome = new CustomerHome();
            cusHome.setUserName("customer");
           // this.Hide();
            cusHome.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //supplier
            pnl_nav.Visible = true;
            pnl_nav.Height = button8.Height;
            pnl_nav.Top = button8.Top;
            pnl_nav.Left = button8.Left;

            SupplierHome supHome = new SupplierHome();
            supHome.setUserName("e000008");
           // this.Hide();
            supHome.Show();
        }

        private void back_up_form_Load(object sender, EventArgs e)
        {
            pnl_nav.Visible = false;
        }
    }
}
