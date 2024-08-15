using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Supplier
{
    public partial class SupplierHome : Form
    {
        public SupplierHome()
        {
            InitializeComponent();
        }

        private void btn_sideBar_two_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();

            if (!NewManagerHome.opendChildForms.Contains("Inventory") && NewManagerHome.opendChildForms.Count <= 2)
            {

                inventory.MdiParent = this;
                inventory.Show();
                NewManagerHome.opendChildForms.Add("Inventory");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }
    }
}
