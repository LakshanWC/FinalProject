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

        private List<string> ShowCaseItemNames = new List<string>();
        private List<int> ShowCaseItemImageNo = new List<int>();
        private List<int> ShowCaseItemQuantity = new List<int>();
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
            BShowCase bShowCase = new BShowCase();
            DataSet ds = new DataSet();
            ds = bShowCase.getShowCaseItemNames();

            
            if(ds != null)
            {
                DataTable dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    ShowCaseItemNames.Add(dr["ItemName"].ToString());
                    ShowCaseItemImageNo.Add(Convert.ToInt32(dr["ImageNo"]));
                    ShowCaseItemQuantity.Add(Convert.ToInt32(dr["Quantity"]));

                    pageCount++;
                }
            }
            else
            {
                TostMessage failMess = new TostMessage("No Show Case Items were found!","Not Found",1,1);
                failMess.Show();
            }

        }

        //show the data in the lists in to ui
        private void loadFromListsToUi(int loadItem)
        {
            if (ShowCaseItemNames.Count != 0)
            {

                ItemImage myImage = new ItemImage();
                BShowCase bShowcase = new BShowCase();
                DataSet ds = new DataSet();


                txt_item_name_one.Text = ShowCaseItemNames[loadItem].ToString();
                pb_item_one.Image = myImage.getItemImage(ShowCaseItemImageNo[loadItem]);
                nud_quntity.Value = Convert.ToDecimal(ShowCaseItemQuantity[loadItem]);

                lbl_page_no.Text = (loadThis + 1) + "/" + pageCount;


                //call the item table and get missing data from there
                ds = bShowcase.getMenuItemPriceAndCalories(txt_item_name_one.Text);
                if (ds != null)
                {
                    DataTable dt = ds.Tables[0];
                    DataRow dtrow = dt.Rows[0];

                    txt_item_price_one.Text = dtrow["itemPrice"].ToString();
                    txt_item_cal_one.Text = dtrow["itemCalories"].ToString();
                }
            }
            else
            {
            }
        }

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
