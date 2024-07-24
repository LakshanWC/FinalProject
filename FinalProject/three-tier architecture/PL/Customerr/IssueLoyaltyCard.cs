using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class IssueLoyaltyCard : Form
    {
        public static string telNo;
        public static string holderName;
        public static DateTime created;

        public IssueLoyaltyCard()
        {
            InitializeComponent();
        }

        private void IssueLoyaltyCard_Load(object sender, EventArgs e)
        {
            txt_telNo.Text = telNo;
            txt_holder_name.Text = holderName;
            dtp_creat_date.Value = created;
        }

        private void btn_get_card_Click(object sender, EventArgs e)
        {
            BIssueLoyaltyCard active = new BIssueLoyaltyCard();
            int isActive = active.activeCard(txt_telNo.Text);
            if (isActive == 1)
            {
                TostMessage mesSucc = new TostMessage("Card Activated Successfuly", "Successful", 3, 3);
                mesSucc.Show();
            }
            else if(isActive == 2)
            {
                TostMessage messFailed = new TostMessage("Card is Already Activated", "Warning", 1,1);
                messFailed.Show();
            }
            else if(isActive == -1)
            {
                TostMessage messUnExpected = new TostMessage("UnExpected Error ", "Error", 2, 2);
                messUnExpected.Show();
            }
            else
            {
                TostMessage messFailed = new TostMessage("Card Activation Faild", "Failed", 5, 5);
                messFailed.Show();
            }
        }

        private void IssueLoyaltyCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            BIssueLoyaltyCard active = new BIssueLoyaltyCard();
             int cardStat = active.activeCard(txt_telNo.Text);

            if(cardStat  == 1 || cardStat == 2)
            {
                NewManagerHome.opendChildForms.Remove("IssueLoyaltyCard");
                this.Close();
            }
            else
            {
                MessageBox.Show("Card inactive. Click Activate !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
