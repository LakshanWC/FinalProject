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
    public partial class Review : Form
    {
        private int count = 0;
        private int btnYesPressed = 0;
        private int btnNoPressed = 0;
        private int btnPressedCount = 0;
        private string itemId;
        private string itemName;

        public Review()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if (btnYesPressed == 0)
            {
                count++;
                no_of_people.Text = count.ToString();
            }
            else
            {
                
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if(count > 0 && btnNoPressed == 0)
            {
                count--;
                no_of_people.Text = count.ToString();
            }
            
        }
        private void setReviewCount(string name)
        {
            BReview getCount = new BReview();
            lbl_review_count.Text = Convert.ToString(getCount.getReviewCount(name));
        }

        private void Review_Load(object sender, EventArgs e)
        {
            FoodMenu menu = new FoodMenu();
            itemId =  menu.getItemId();
            DataSet data = new DataSet();

            BReview getName = new BReview();

            if (itemId == null)
            {
                data = getName.getAllReviewItemNames();
                setAllNamesToCMB(data);
            }
            else
            {
                itemName = getName.getItemName(itemId);
                if(itemName != null)
                {
                    cmb_selected_item.Items.Add(itemName);
                    cmb_selected_item.SelectedIndex = 0;
                }
                else if(itemName == "exception")
                {
                    TostMessage msg = new TostMessage("Unexpected Error", "Error",3,3);
                    msg.Show();
                }
                else
                {
                    TostMessage msg = new TostMessage("No Review found!", "Faild", 2, 2);
                    msg.Show();
                }
            }
        }

        public void setAllNamesToCMB(DataSet ds)
        {
            if(ds != null)
            {
                DataTable tbl = ds.Tables[0];
                cmb_selected_item.Items.Clear(); 
                foreach (DataRow row in tbl.Rows)
                {
                    // Add each itemName to ComboBox
                    cmb_selected_item.Items.Add(row["itemName"].ToString());
                    
                }
                cmb_selected_item.SelectedIndex = 0;
            }
            else
            {
                TostMessage msg = new TostMessage("No Review found!", "Faild", 2, 2);
                msg.Show();
            }
        }

        private void cmb_selected_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemName = cmb_selected_item.SelectedItem.ToString();

            setReviewCount(itemName);

            BReview reviews = new BReview();
            DataSet reData = new DataSet();

            reData = reviews.getReviewData(itemName);
            setReviewData(reData, btnPressedCount);
                
        }

        private void setReviewData(DataSet results ,int btnPressCount)
        {
            if (results.Tables.Count > 0)
            {

                DataTable table = results.Tables[0];
                int maxRows = table.Rows.Count;

                if (btnPressCount < 0 || btnPressCount >= maxRows)
                {
                    // Reset to 0 if out of bounds
                    btnPressCount = 0;
                }
                else
                {
                    DataRow row = table.Rows[btnPressCount];

                    nud_review_score.Value = Convert.ToInt32(row["Rrate"]);
                    no_of_people.Text = row["Rpoint"].ToString();
                    txt_description.Text = row["RComment"].ToString();
                }
            }
            else
            {
                TostMessage msg = new TostMessage("No Review found!", "Faild", 2, 2);
                msg.Show();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            btnPressedCount ++;
        }

        private void btn_priveous_Click(object sender, EventArgs e)
        {
            btnPressedCount --;
        }
    }
}
