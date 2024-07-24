using FinalProject.three_tier_architecture.BLL.Customer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class CustomerHome : Form
    {
        public static string curruntCusId ;

        public CustomerHome()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
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

        public void setUserName(string userName)
        {
            BCustomerHome uId = new BCustomerHome();
            lbl_userName.Text = userName;
            if (uId.getUserId(userName) != null) {
                lbl_user_id.Text = (uId.getUserId(userName));
                curruntCusId = lbl_user_id.Text;


            }
            else
            {
                lbl_user_id.Text = "not found";
                curruntCusId = "not found";
            }
            
        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {

        }

        private void addReivewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReview review = new CustomerReview();

            if (!NewManagerHome.opendChildForms.Contains("CustomerReview") && NewManagerHome.opendChildForms.Count <= 2)
            {
                //this.tlp_dash_board.Visible = false;

                review.MdiParent = this;
                review.Show();
                NewManagerHome.opendChildForms.Add("CustomerReview");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
