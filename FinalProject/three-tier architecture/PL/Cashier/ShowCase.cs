using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Cashier;
using FinalProject.three_tier_architecture.BLL.Customer;
using FinalProject.three_tier_architecture.DAL.Cashier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Cashier
{
    public partial class ShowCase : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private List<string> showCaseItemNames = new List<string>();
        private List<string> showCaseItemPrice = new List<string>();
        private List<string> showCaseItemCal = new List<string>();
        private List<int> showCaseItemImageNo = new List<int>();
        private List<int> showCaseItemQuantity = new List<int>();
        private int loadThis = 0;

        private int pageCount = 0;

        public ShowCase()
        {
            InitializeComponent();
        }

        private void ShowCase_Load(object sender, EventArgs e)
        {
            initLists();
            loadFromListsToUi(loadThis);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(loadThis < pageCount-1)
            {
                loadThis++;
                loadFromListsToUi(loadThis);
            }
            else
            {
                loadThis = 0;
                loadFromListsToUi(loadThis);
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (loadThis > 0)
            {
                loadThis--;
                loadFromListsToUi(loadThis);
            }
            else
            {
                loadThis = 0;
                loadFromListsToUi(loadThis );
            }
        }


        //add the showcase item to lists
        private void initLists()
        {
            BShowCase myShowCase = new BShowCase();
            DataSet data = new DataSet();
            data = myShowCase.getShowCaseItemNames();

            if(data != null)
            {
                DataTable dt = data.Tables[0];
                foreach(DataRow dr in dt.Rows)
                {
                    showCaseItemNames.Add(dr["itemName"].ToString());
                    showCaseItemPrice.Add(dr["itemPrice"].ToString());
                    showCaseItemCal.Add(dr["itemCalories"].ToString());
                    showCaseItemQuantity.Add(Convert.ToInt32(dr["showcaseItem"]));
                    showCaseItemImageNo.Add(Convert.ToInt32(dr["itemImageNo"]));

                    pageCount++;
                }
            }
        }

        //show the data in the lists in to ui
        private void loadFromListsToUi(int loadItem)
        {
            txt_item_name_one.Text = showCaseItemNames[loadItem].ToString();
            txt_item_price_one.Text = showCaseItemPrice[loadItem].ToString();
            txt_item_cal_one.Text = showCaseItemCal[loadItem].ToString();
            nud_quntity.Value = Convert.ToDecimal(showCaseItemQuantity[loadItem]);

            //loadImage
            ItemImage myImages = new ItemImage();
            pb_item_one.Image = myImages.getItemImage(Convert.ToInt32(showCaseItemImageNo[loadThis]));

            //set page count in ui
            lbl_page_no.Text = (loadThis+1)+"/"+pageCount;
        }

        //dont change

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("ShowCase");
            this.Close();
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
