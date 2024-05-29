using FinalProject.MVC.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.MVC.View
{
    public partial class PasswordRequest : Form
    {
        public PasswordRequest()
        {
            InitializeComponent();
        }

        private void PasswordRequest_Load(object sender, EventArgs e)
        {
            CPassResetRequests passRsetObj = new CPassResetRequests();
            DataSet ds = passRsetObj.getPassRequests();

            if(ds.Tables.Count > 0 )
            {
                dgv_pass_requests.DataSource = ds.Tables[0];
            }
           
        }
    }
}
