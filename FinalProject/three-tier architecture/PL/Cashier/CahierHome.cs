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
    }
}
