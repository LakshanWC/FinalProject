using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Cashier;
using FinalProject.three_tier_architecture.BLL.Waiter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Waiter
{
    public partial class CustomerRequests : Form
    {
        private int currentRowIndex = 0;
        private DataTable dt;

        public CustomerRequests()
        {
            InitializeComponent();
        }

        private void CustomerRequests_Load(object sender, EventArgs e)
        {
            cmb_request_type.SelectedIndex = 0;
            getData();
            LoadData(currentRowIndex);
        }

        private void getData()
        {
            BCustomerRequests comp = new BCustomerRequests();
            DataSet ds = new DataSet();
            ds = comp.getRequestData(cmb_request_type.SelectedItem.ToString());

            dt = ds.Tables[0];
        }

        private void LoadData(int rowIndex)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[rowIndex];
                txt_tableNO.Text = dr["tableNo"].ToString();
                // txt_reqType.Text = dr["requestType"].ToString();

                string requestType = dr["requestType"].ToString();
                int index = cmb_request_type.Items.IndexOf(requestType);

                // If the item exists in the ComboBox, select it
                if (index != -1)
                {
                    cmb_request_type.SelectedIndex = index;
                }
                else
                {
                    cmb_request_type.SelectedIndex = -1; // Or handle it differently if the item is not found
                }

                txt_description.Text = dr["requestDetails"].ToString();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentRowIndex < dt.Rows.Count - 1)
            {
                currentRowIndex++;
                LoadData(currentRowIndex);
            }
            else
            {
                TostMessage tosMess = new TostMessage("You are at the last record.", "Information", 1, 1);
                tosMess.Show();
            }
        }

        private void btn_pervios_Click(object sender, EventArgs e)
        {
            if (currentRowIndex > 0)
            {
                currentRowIndex--;
                LoadData(currentRowIndex);
            }
            else
            {
                TostMessage tostMessage = new TostMessage("You are at the first record.", "Information", 1, 1);
                tostMessage.Show();
            }
        }

        private void cmb_request_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData();
            LoadData(currentRowIndex);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("CustomerRequests");
            this.Dispose();
        }
    }
}
