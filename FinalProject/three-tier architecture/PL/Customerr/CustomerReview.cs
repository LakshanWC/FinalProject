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

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class CustomerReview : Form
    {
        public CustomerReview()
        {
            InitializeComponent();
        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            count = txt_description.Text.Length;
            lbl_no_of_letters.Text = $"{count}/500";

        }

        private void txt_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text.Length >= 500 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void CustomerReview_Load(object sender, EventArgs e)
        {
            txt_cutomer_id.Text = CustomerHome.curruntCusId;

            BCustomerReview name = new BCustomerReview();
            DataSet ds = new DataSet();
            ds = name.getItemNames();

            setCMBValues(ds);

        }

        private void setCMBValues(DataSet data)
        {
            if (data != null && data.Tables.Count > 0)
            {
                DataTable dt = data.Tables[0];

                //clear existing items 
                cmb_selected_item.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string temp = dt.Rows[i][0].ToString(); 
                    cmb_selected_item.Items.Add(temp);
                }
                cmb_selected_item.SelectedIndex = 0;
            }
            else
            {
                TostMessage messFail = new TostMessage("No data found.", "Error",3,3);
                messFail.Show();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearUi();
        }

        private void clearUi()
        {
            txt_description.Clear();
            nud_review_score.Value = 1;
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_description.Text)&& (!string.IsNullOrEmpty(txt_cutomer_id.Text) &&
                nud_review_score.Value != 0))
            {
                string cusId = txt_cutomer_id.Text;
                string itemName = cmb_selected_item.SelectedItem.ToString();
                int reviewScore = Convert.ToInt32(nud_review_score.Value);
                string comment = txt_description.Text;

                BCustomerReview review = new BCustomerReview();
                int stat = review.addReview(cusId, itemName, reviewScore,comment);


                if(stat == 0)
                {
                    clearUi();
                    TostMessage messFailed = new TostMessage("Review Adding Failed", "Faild", 1, 1);
                    messFailed.Show();
                }
                else if(stat == 1)
                {
                    clearUi();
                    TostMessage messSucc = new TostMessage("Review Added Successfuly", "Successful", 3, 3);
                    messSucc.Show();
                }
                else if (stat == 2)
                {
                    clearUi();
                    TostMessage messFail = new TostMessage("Review Already exisits by this Id","Warning",1,1);
                    messFail.Show();
                }
                else if( stat == -1)
                {
                    clearUi();
                    TostMessage messUnexError = new TostMessage("Unexpected Error Occurred", "Unexpected", 2,2);
                    messUnexError.Show();
                }


            }
            else
            {
                MessageBox.Show("Please Fill all the Fields!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Contains("CustomerReview");
            this.Close();
        }
    }
}
