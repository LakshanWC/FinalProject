using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class OrderFood : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private double discount;
        private Image itemImage;
        private DateTime createdDate = DateTime.Now;

        private decimal firstPrice = 0;
        private decimal finalTot = 0;

        public OrderFood()
        {
            InitializeComponent();
        }

        private void OrderFood_Load(object sender, EventArgs e)
        {
            txt_loyal_card_tel_no.Enabled = false;
            cmb_delivery_option.SelectedIndex = 0;
            cmb_payment_method.SelectedIndex = 0;
           

            BOrderFood genId = new BOrderFood();
            txt_order_id.Text = genId.generateUniqueString();
        }

        public void setSelectedItemsToCB (List<string> selectedItems)
        {
            foreach (string item in selectedItems) 
            {
                cmb_selected_item.Items.Add(item);
            }
            cmb_selected_item.SelectedIndex = 0;
        }

        private void rbtn_loyal_yes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_loyal_yes.Checked)
            {
                txt_loyal_card_tel_no.Enabled=true;
                cmb_delivery_option.Items.Add("Express Delivery");

            }
        }

        private void rbtn_loyal_no_CheckedChanged(object sender, EventArgs e)
        {
            double itemPrice = Convert.ToDouble(txt_item_price.Text);
            double quantitiy = (double)nud_item_quantity.Value;

            if (rbtn_loyal_no.Checked)
            {
                txt_loyal_card_tel_no.Enabled=false;
                cmb_delivery_option.Items.Remove("Express Delivery");

                txt_total_price.Text =  Convert.ToString(itemPrice * quantitiy);
            }
        }

        private void cmb_selected_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            BOrderFood data = new BOrderFood();
            DataSet results = new DataSet();
            results = data.getItemData(cmb_selected_item.SelectedItem.ToString());

            if (results != null)
            {
                setUIData(results);
                double itemPrice = Convert.ToDouble(txt_item_price.Text);
                double quantitiy = (double)nud_item_quantity.Value;
                txt_total_price.Text =  Convert.ToString(itemPrice * quantitiy);
            }
        }

        public void setUIData(DataSet data)
        {
            DataTable table = data.Tables[0];
            ItemImage getImage = new ItemImage();

            for(int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                itemImage = getImage.getItemImage(Convert.ToInt32(row["itemImageNo"]));
                pb_item_image.Image = itemImage;

                txt_item_name.Text = row["itemName"].ToString();
                txt_item_price.Text = row["itemPrice"].ToString();
                txt_item_cal.Text = row["itemCalories"].ToString();
            }

        }

        private void nud_item_quantity_ValueChanged(object sender, EventArgs e)
        {
            double itemPrice = Convert.ToDouble(txt_item_price.Text);
            double quantitiy = (double)nud_item_quantity.Value;

            if (discount != null && !string.IsNullOrEmpty(txt_loyal_card_tel_no.Text) && rbtn_loyal_yes.Checked)
            {
                txt_total_price.Text =  Convert.ToString((itemPrice * quantitiy)-discount);
                addDiscount();
            }
            else
            {
                txt_total_price.Text =  Convert.ToString(itemPrice * quantitiy);
            }
        }

        private void txt_loyal_card_tel_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_use_card_points_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkCard()
        {
            if (!string.IsNullOrEmpty(txt_loyal_card_tel_no.Text))
            {
                BOrderFood card = new BOrderFood();
                int results = card.checkCard(txt_loyal_card_tel_no.Text);
                if (results == -1)
                {
                    //exception happend
                    TostMessage messFaild = new TostMessage("UnExpected Error","Error",2,2);
                    messFaild.Show();
                }
                else if (results == 1) 
                {
                    //card found
                    addDiscount();

                }
                else if(results == 0)
                {
                    //Card not 
                    MessageBox.Show("Loyalty Card Not Found Please Check the TelNo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Please Fill Loyalty Card TelNo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_delivery_option_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_payment_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        public void addDiscount()
        {
            // get total amount spent 
            double total = Convert.ToDouble(txt_total_price.Text);

            //discount percentage based on the total amount
            double discountPercentage = 0.0;

            if (total > 5000)
            {
                discountPercentage = 0.10; // 3% discount
            }
            else if (total > 2000)
            {
                discountPercentage = 0.08; // 2% discount
            }
            else if (total > 0)
            {
                discountPercentage = 0.03; // 1% discount
            }

            // Calculate discount amount
             discount = total * discountPercentage;

            // Display calculated discount 
            lbl_discount_ammount.Text = $"LKR {discount:F2}";

            double price = Convert.ToDouble(txt_total_price.Text);
            double totPrice = price - discount;
            totPrice = Math.Round(totPrice, 2); // Rounds to 2 decimal places
            txt_total_price.Text = $"{totPrice:F2}";
        }

        private void btn_calculate_discount_Click(object sender, EventArgs e)
        {
            if(rbtn_loyal_yes.Checked && !string.IsNullOrEmpty(txt_loyal_card_tel_no.Text))
            {
                checkCard();
                btn_calculate_discount.Enabled = false;

            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            try
            {

                int orderQuntity = Convert.ToInt32(nud_item_quantity.Value);
            // createdDate has the date

            int orderStatus = cmb_delivery_option.SelectedIndex;
            string cNo;
            if (CustomerHome.curruntCusId == null)
            {
                cNo = "Guest";
            }
            else
            {
                cNo = CustomerHome.curruntCusId;
            }
            string itemName = txt_item_name.Text;
            string uniqeKey = txt_order_id.Text;
            decimal totPrice = Convert.ToDecimal(txt_total_price.Text);
            
            if(rbtn_loyal_no.Checked || rbtn_loyal_yes.Checked && cmb_payment_method.SelectedIndex != 0)
            {
                BOrderFood foodOrder = new BOrderFood();
                bool isOrdered = foodOrder.addOrder(orderQuntity, createdDate,orderStatus,cNo,itemName,uniqeKey,totPrice);
                if (isOrdered) 
                {
                    
                        // set all item total

                        firstPrice = Convert.ToDecimal(txt_total_price.Text);
                        finalTot = firstPrice + finalTot;
                        txt_all_item_total.Text = (finalTot).ToString("F2");

                        int selectedInt = cmb_selected_item.SelectedIndex;

                        cmb_selected_item.Items.RemoveAt(selectedInt);


                        txt_item_cal.Clear();
                        txt_item_price.Clear();
                        txt_item_name.Clear();

                        if (cmb_selected_item.Items.Count > 0)
                        {
                            cmb_selected_item.SelectedIndex = 0;
                            nud_item_quantity.Value = 1;
                        }
                        if(cmb_selected_item.Items.Count == 0)
                        {
                            txt_total_price.Clear();
                            cmb_selected_item.Items.Clear();
                            btn_order_customize.Enabled = false;
                        }

                        TostMessage messSucc = new TostMessage("Order Added Successfully", "Successful", 3, 3);
                        messSucc.Show();

                }
                else
                {
                    TostMessage messFail = new TostMessage("Order Adding Failed","Failed",2,2);
                }
            }
                else
                {
                MessageBox.Show("Please fill out the details","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There Are No Items Left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_total_price_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (cmb_selected_item.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Some items are not ordered. Exit anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                getClickedButton(result);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you Want a Bill ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                getClickedButton(result);

            }
        }

        //check if the usre wants a bill for the order
        private void getClickedButton(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("bill--   ~(OvO)~  --bill ");
            }
            else if (result == DialogResult.No)
            {
                NewManagerHome.opendChildForms.Remove("OrderFood");
                this.Close();
            }
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
