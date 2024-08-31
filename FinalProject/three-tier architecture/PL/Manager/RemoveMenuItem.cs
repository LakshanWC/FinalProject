using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL.Manager
{
    public partial class RemoveMenuItem : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public RemoveMenuItem()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Add("RemoveMenuItem");
            this.Dispose();
        }

        private void RemoveMenuItem_Load(object sender, EventArgs e)
        {
            BRemoveMenuItem myMenu = new BRemoveMenuItem();
            DataSet ds = myMenu.getItemNames();
            setNames(ds);


        }
        private void setNames(DataSet ds)
        {
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    cmb_event_type.Items.Add(row["itemName"].ToString());
                }
                cmb_event_type.SelectedIndex = 0;
            }
            else if (ds == null)
            {
                TostMessage messFail = new TostMessage("No Items Found!", "Warning", 1, 1);
                messFail.Show();
            }
        }

        private void setUiData(DataSet data)
        {
            try
            {

                if (data != null)
                {
                    DataTable dt = data.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        txt_item_name.Text = row["itemName"].ToString();
                        txt_item_calories.Text = row["itemCalories"].ToString();
                        txt_item_price.Text = row["itemPrice"].ToString();
                        int imageNo = Convert.ToInt32(row["itemImageNo"]);

                        ItemImage imageType = new ItemImage();
                        Image currentItemImage = imageType.getItemImage(imageNo);
                        pb_item_image.Image = currentItemImage;
                    }
                }
                else if (data == null)
                {
                    TostMessage messFail = new TostMessage("No Items Found!", "Warning", 1, 1);
                    messFail.Show();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void cmb_event_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            BRemoveMenuItem myMenu = new BRemoveMenuItem();
            setUiData(myMenu.getMenuItemsData(cmb_event_type.SelectedItem.ToString()));
        }

        private void btn_remove_item_Click(object sender, EventArgs e)
        {
            BRemoveMenuItem remItem = new BRemoveMenuItem();
            bool stat = remItem.deleteMenuItem(cmb_event_type.SelectedItem.ToString());
            if (stat)
            {
                TostMessage messSucc = new TostMessage("Item Successfully deleted","Success",3,3);
                messSucc.Show();
                cmb_event_type.Items.Clear();
                setNames(remItem.getItemNames());
            }
            else
            {
                TostMessage messFail = new TostMessage("Faild to Delete Selected Item","Faild",2,2);
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
