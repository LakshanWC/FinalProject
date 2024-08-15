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

namespace FinalProject.three_tier_architecture.PL.Supplier
{
    public partial class StockOrderRequest : Form
    {
        public StockOrderRequest()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockOrderRequest_Load(object sender, EventArgs e)
        {
            BStockOrderRequest request = new BStockOrderRequest();
            loadGridViewData(request.getRequests(false));
            cb_loadAll.Checked = false;
        }

        private void loadGridViewData(DataSet results)
        {
            if(cb_loadAll.Checked == false && results.Tables[0].Rows.Count == 0)
            {
                TostMessage messFaild = new TostMessage("No deliveries found for today.", "Warning", 1, 1);
                messFaild.Show();

            }
            else if(cb_loadAll.Checked == true && results.Tables[0].Rows.Count == 0)
            {
                TostMessage messFaild = new TostMessage("No deliveries found.", "Warning", 1, 1);
                messFaild.Show();

            }
            else if(results != null)
            {
                dgv_requests.DataSource = results.Tables[0];
            }
        }

        private void cb_loadAll_CheckedChanged(object sender, EventArgs e)
        {
            BStockOrderRequest requests = new BStockOrderRequest();

            // Clear DataGridView 
            dgv_requests.DataSource = null;
            loadGridViewData(requests.getRequests(cb_loadAll.Checked));
        }
    }
}
