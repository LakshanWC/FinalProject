using FinalProject.MVC;
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
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Customerr
{
    public partial class OrderCustomize : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private DateTime SpcreatDate;
        private string deliveryOption;

        public OrderCustomize()
        {
            InitializeComponent();
        }

        private void OrderCustomize_Load(object sender, EventArgs e)
        {
            //select this if there is an item
            if (cmb_selected_item.Items.Count > 0)
            {
                cmb_selected_item.SelectedIndex = 0;
            }
        }

        //set Ui data
        public void passData(string orderId, string selectedOrder, string itemName, string price,
            Image itemImage, int imageNo, DateTime createdDate,string delivery)
        {
            txt_order_id.Text = orderId;
            cmb_selected_item.Items.Add(selectedOrder);
            txt_item_name.Text = itemName;
            txt_price.Text = price;
            pb_item_one.Image = itemImage;
            SpcreatDate = createdDate;
            deliveryOption = delivery;
            setCustomizeOptions(imageNo);
            CalculateCustomizationPrice();
        }

        // Add different customization options
        private void setCustomizeOptions(int imageNo)
        {
            // Clear the ComboBox items first
            cmb_first_option.Items.Clear();
            cmb_second_option.Items.Clear();
            cmb_third_option.Items.Clear();

            // Beverages
            if (imageNo == 7 || imageNo == 8 || imageNo == 9)
            {
                // Add options for beverages
                cmb_first_option.Items.AddRange(new string[] { "No Sugar", "Less Sugar", "Extra Sugar" });
                cmb_second_option.Items.AddRange(new string[] { "Add Lemon", "Add Ice", "No Ice" });
                cmb_third_option.Items.AddRange(new string[] { "Whole Milk", "Skim Milk", "Almond Milk" });
            }
            // Foods
            else if (imageNo == 1 || imageNo == 2 || imageNo == 3 || imageNo == 4 || imageNo == 5 || imageNo == 6
                || imageNo >= 10 || imageNo <= 0)
            {
                // Add options for food
                cmb_first_option.Items.AddRange(new string[] { "Extra Rice", "Extra Cheese", "Add Chicken" });
                cmb_second_option.Items.AddRange(new string[] { "Spicy", "Mild", "Well-done" });
                cmb_third_option.Items.AddRange(new string[] { "Gluten-free", "Vegan", "Nut-free" });
            }

            cmb_first_option.SelectedIndex = 0;
            cmb_second_option.SelectedIndex = 0;
            cmb_third_option.SelectedIndex = 0;
        }

        // Method to calculate the price based on selected options
        private void CalculateCustomizationPrice()
        {
            decimal price = 0;
            decimal itemPrice = Convert.ToDecimal(txt_price.Text);

            // First option
            switch (cmb_first_option.SelectedIndex)
            {
                case 0: // Extra Rice
                    price += 100;
                    break;
                case 1: // Extra Cheese
                    price += 150;
                    break;
                case 2: // Add Chicken
                    price += 200;
                    break;
                case 3: // No Sugar
                case 4: // Less Sugar
                case 5: // Extra Sugar
                    price += 50;
                    break;
            }

            // Second option
            switch (cmb_second_option.SelectedIndex)
            {
                case 0: // Spicy
                    price += 0;
                    break;
                case 1: // Mild
                    price += 0;
                    break;
                case 2: // Well-done
                    price += 0;
                    break;
                case 3: // Add Lemon
                    price += 30;
                    break;
                case 4: // Add Ice
                    price += 20;
                    break;
                case 5: // No Ice
                    price += 0;
                    break;
            }

            // Third option
            switch (cmb_third_option.SelectedIndex)
            {
                case 0: // Gluten-free
                    price += 100;
                    break;
                case 1: // Vegan
                    price += 150;
                    break;
                case 2: // Nut-free
                    price += 120;
                    break;
                case 3: // Whole Milk
                    price += 60;
                    break;
                case 4: // Skim Milk
                    price += 50;
                    break;
                case 5: // Almond Milk
                    price += 70;
                    break;
            }

            txt_total_price.Text = (itemPrice +price).ToString("F2");
        }

        private void cmb_first_option_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateCustomizationPrice();
        }

        private void cmb_second_option_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateCustomizationPrice();
        }

        private void cmb_third_option_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateCustomizationPrice();
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            txt_description.Clear();
            cmb_first_option.SelectedIndex = 0;
            cmb_second_option.SelectedIndex = 0;
            cmb_third_option.SelectedIndex = 0;

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            string deliveryStat;

            if(deliveryOption == "Take Out" || deliveryOption == "Dine in")
            {
                deliveryStat = "non";
            }
            else
            {
                deliveryStat = deliveryOption;
            }

            if (cmb_selected_item.Items.Count != 0 && !string.IsNullOrEmpty(txt_item_name.Text))
            {



                int orderQuantity = Convert.ToInt32(nud_item_quantity.Value);
                string orderStatus = deliveryOption;
                string itemName = txt_item_name.Text;
                string uniqueKey = txt_order_id.Text;
                decimal totPrice = Convert.ToDecimal(txt_total_price.Text);
                string extraItem1 = cmb_first_option.SelectedItem.ToString();
                string extraItem2 = cmb_second_option.SelectedItem.ToString();
                string extraItem3 = cmb_third_option.SelectedItem.ToString();
                string SORdetails = txt_description.Text;

                int isOrdered;

                BOrderCustomize orderCustomizeFood = new BOrderCustomize();
                isOrdered = orderCustomizeFood.addSpecialOrder(orderQuantity, SpcreatDate, orderStatus, itemName
                    , uniqueKey, totPrice, extraItem1, extraItem2, extraItem3, SORdetails,deliveryStat);

                if (isOrdered == 1)
                {
                    TostMessage messSucc = new TostMessage("Order Added Successfully", "Successful", 3, 3);
                    messSucc.Show();
                    clearUi();
                }
                else if (isOrdered == 0)
                {
                    TostMessage messError = new TostMessage("Order Adding Faild", "Faild", 1, 1);
                    messError.Show();
                }
                else if (isOrdered == -1)
                {
                    TostMessage messException = new TostMessage("Unexpected Error", "Error", 2, 2);
                    messException.Show();
                }
            }
            else
            {
                MessageBox.Show("There Are No Items Left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void clearUi()
        {
            txt_order_id.Clear();
            txt_price.Clear();
            txt_description.Clear();
            cmb_selected_item.Items.Clear();
            cmb_first_option.Items.Clear();
            cmb_second_option.Items.Clear();
            cmb_third_option.Items.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("OrderCustomize");
            CahierHome.isCahierOpen = false;
            this.Close();
        }

        private void nud_item_quantity_ValueChanged(object sender, EventArgs e)
        {
            decimal unitPrice = Convert.ToDecimal(txt_total_price.Text);

            // Get the current quantity from num up down
            decimal quantity = nud_item_quantity.Value;

            // Calculate the new total price
            decimal totalPrice = unitPrice * quantity;

            // Update the total price & display
            txt_total_price.Text = totalPrice.ToString("F2");
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

