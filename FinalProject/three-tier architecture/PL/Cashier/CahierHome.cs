using FinalProject.three_tier_architecture.PL.Customerr;
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

namespace FinalProject.three_tier_architecture.PL.Cashier
{
    public partial class CahierHome : Form
    {
        public static bool isCahierOpen = false;

        public CahierHome()
        {
            InitializeComponent();
        }

        private void btn_sideBar_two_Click(object sender, EventArgs e)
        {
            CheckInventory inventory = new CheckInventory();

            if (!NewManagerHome.opendChildForms.Contains("CheckInventory") && NewManagerHome.opendChildForms.Count <= 2)
            {

                inventory.MdiParent = this;
                inventory.Show();
                NewManagerHome.opendChildForms.Add("CheckInventory");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_one_Click(object sender, EventArgs e)
        {
            isCahierOpen=true;
            FoodMenu menu = new FoodMenu();

            if (!NewManagerHome.opendChildForms.Contains("FoodMenu") && NewManagerHome.opendChildForms.Count <= 2)
            {
                //this.tlp_dash_board.Visible = false;

                menu.MdiParent = this;
                menu.Show();
                NewManagerHome.opendChildForms.Add("passRequest");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_sideBar_thire_Click(object sender, EventArgs e)
        {
            MenuUpdate update = new MenuUpdate();

            if (!NewManagerHome.opendChildForms.Contains("MenuUpdate") && NewManagerHome.opendChildForms.Count <= 2)
            {
                update.MdiParent = this;
                update.Show();
                NewManagerHome.opendChildForms.Add("MenuUpdate");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }
    }
}
