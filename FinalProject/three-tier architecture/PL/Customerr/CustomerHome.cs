using FinalProject.MVC.View;
using FinalProject.three_tier_architecture.BLL.Customer;
using FinalProject.three_tier_architecture.PL.Cashier;
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

        private void registerForLoyaltyCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForLoyaltyCard loyaltyCard = new RegisterForLoyaltyCard();

            if (!NewManagerHome.opendChildForms.Contains("RegisterForLoyaltyCard") && NewManagerHome.opendChildForms.Count <= 2)
            {
                loyaltyCard.MdiParent = this;
                loyaltyCard.Show();
                NewManagerHome.opendChildForms.Add("RegisterForLoyaltyCard");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderConfirmation orderConf = new OrderConfirmation();
            orderConf.MdiParent = this;
            orderConf.Show();
        }

        private void reviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Review update = new Review();

            if (!NewManagerHome.opendChildForms.Contains("Review") && NewManagerHome.opendChildForms.Count <= 2)
            {
                update.MdiParent = this;
                update.Show();
                NewManagerHome.opendChildForms.Add("Review");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void resevationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation update = new Reservation();

            if (!NewManagerHome.opendChildForms.Contains("Reservation") && NewManagerHome.opendChildForms.Count <= 2)
            {
                update.MdiParent = this;
                update.Show();
                NewManagerHome.opendChildForms.Add("Reservation");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void requestAssistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestAssistant update = new RequestAssistant();

            if (!NewManagerHome.opendChildForms.Contains("RequestAssistant") && NewManagerHome.opendChildForms.Count <= 2)
            {
                update.MdiParent = this;
                update.Show();
                NewManagerHome.opendChildForms.Add("RequestAssistant");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_track_delivery_Click(object sender, EventArgs e)
        {
            TrackDelivery update = new TrackDelivery();

            if (!NewManagerHome.opendChildForms.Contains("TrackDelivery") && NewManagerHome.opendChildForms.Count <= 2)
            {
                update.MdiParent = this;
                update.Show();
                NewManagerHome.opendChildForms.Add("TrackDelivery");
            }
            else
            {
                MessageBox.Show("instens already exisit");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MVC.View.Login logout = new MVC.View.Login();
            this.Hide();
            logout.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close(); // Close each child form
            }
            NewManagerHome.opendChildForms.Clear();
        }
    }
}
