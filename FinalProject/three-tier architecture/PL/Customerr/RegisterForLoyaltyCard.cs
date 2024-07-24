using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class RegisterForLoyaltyCard : Form
    {
        string customerId;
        string cardHolderName;
        string telNo;
        DateTime createdDate;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public RegisterForLoyaltyCard()
        {
            InitializeComponent();
        }

        private void RegisterForLoyaltyCard_Load(object sender, EventArgs e)
        {
            dtp_creat_date.Value = DateTime.Now;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            customerId = txt_customer_id.Text;
            telNo = txt_tel_no.Text;
            createdDate = DateTime.Now;
            cardHolderName = txt_card_holder_name.Text;

            if (!string.IsNullOrEmpty(txt_customer_id.Text) && !string.IsNullOrEmpty(txt_card_holder_name.Text)
                && !string.IsNullOrEmpty(txt_tel_no.Text))
            {
                BRegisterForLoyaltyCard newLoyaltyCard = new BRegisterForLoyaltyCard();
                int results = newLoyaltyCard.addLoyaltyCard(customerId, cardHolderName, telNo, createdDate);

                if(results == 1) 
                {
                    TostMessage tostSuccses = new TostMessage("Registration successful", "Success", 3,3);
                    tostSuccses.Show();
                    //Pass data to other ui
                    IssueLoyaltyCard.telNo = txt_tel_no.Text;
                    IssueLoyaltyCard.holderName = txt_card_holder_name.Text;
                    IssueLoyaltyCard.created = dtp_creat_date.Value;

                    this.Hide();

                    IssueLoyaltyCard card = new IssueLoyaltyCard();

                    if (!NewManagerHome.opendChildForms.Contains("showReview") && NewManagerHome.opendChildForms.Count <= 2)
                    {
                        CustomerHome Home = this.MdiParent as CustomerHome;
                        Home.IsMdiContainer = true;

                        if (Home != null)
                        {
                            card.MdiParent = Home;
                            card.Show();

                            NewManagerHome.opendChildForms.Add("Review");
                        }
                        else
                        {
                            MessageBox.Show("MDI Parent is not set correctly.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Instance already exists");
                    }
                }


                else if(results == 2) 
                {
                    TostMessage tostSuccess = new TostMessage("Card already exists for this number", "Failed", 1, 1);
                    tostSuccess.Show();
                    clearUi();
                }
                else if (results == 0)
                {
                    TostMessage tostSuccess = new TostMessage("Registration failed", "Failed", 1, 1);
                    tostSuccess.Show();
                    clearUi();
                }
                else 
                {
                    TostMessage tostSuccess = new TostMessage("Customer Id does not exists", "Error", 2, 2);
                    tostSuccess.Show();
                    clearUi();
                }
            }
            else 
            {
                MessageBox.Show("Please Fill the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_tel_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        //get TelNo
        public string getTelNo() { return txt_tel_no.Text; }
        //get Creat Date
        public DateTime getCreatDate() { return dtp_creat_date.Value;}
        //get CardHolder Name
        public string getCardHolderName() { return txt_card_holder_name.Text; }

        private void txt_tel_no_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length > 10)
            {
                // Limit the text length to 10 characters
                textBox.Text = textBox.Text.Substring(0, 10);
                textBox.SelectionStart = textBox.Text.Length; // Move cursor to the end
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("RegisterForLoyaltyCard");
            this.Close();
        }

        public void clearUi() 
        {
            txt_customer_id.Clear();
            txt_card_holder_name.Clear();
            txt_tel_no.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearUi();
        }

        private void pnl_title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void pnl_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pnl_title_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
