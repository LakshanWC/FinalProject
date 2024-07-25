using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Chef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject.three_tier_architecture.PL.Chef
{
    public partial class ReceivedOrder : Form
    {
        public ReceivedOrder()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReceivedOrder_Load(object sender, EventArgs e)
        {
            BReceivedOrder order = new BReceivedOrder();
            DataSet results = order.getOrders();
            loadToDataGrid(results);
        }

        //load dataset to dataGrid view
        private void loadToDataGrid(DataSet results)
        {
            // Make sure dataSet is not null
            if (results != null && results.Tables.Count > 0)
            {
                // Set the DataSource of the DataGridView to the first DataTable in the DataSet
                dgv_orders.DataSource = results.Tables[0];

                // set Auto-generate as true
                dgv_orders.AutoGenerateColumns = true;
            }
            else
            {
                dgv_orders.DataSource = null;
                TostMessage messFaild = new TostMessage("No Orders Were Found","Faild",1,1);
                messFaild.Show();
            }
        }

    }
}
