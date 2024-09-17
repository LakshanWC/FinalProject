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

            NewManagerHome mHome = new NewManagerHome();
            mHome.setUserName("e000002");
            //this.Hide();
            mHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sales

            SalesAndFinanceHome saleHome = new SalesAndFinanceHome();
            saleHome.setUserName("e000006");
            //this.Hide();
            saleHome.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Cahirer

            CahierHome cashHo = new CahierHome();
            cashHo.setUserName("e000004");
          //  this.Hide();
            cashHo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Chef

            ChefHome chfHom = new ChefHome();
            chfHom.setUserName("e000003");
            // this.Hide();
            chfHom.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //waiter

            WaiterHome waitHome = new WaiterHome();
            waitHome.setUserName("e000007");
            //this.Hide();
            waitHome.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delivery

            DeliveryTeamHome dTHome = new DeliveryTeamHome();
            dTHome.setUserName("e000005");
           // this.Hide();
            dTHome.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //customer

            CustomerHome cusHome = new CustomerHome();
            cusHome.setUserName("customer");
           // this.Hide();
            cusHome.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //supplier

            SupplierHome supHome = new SupplierHome();
            supHome.setUserName("e000008");
           // this.Hide();
            supHome.Show();
        }
    }
}
