using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Chef;
using FinalProject.three_tier_architecture.DAL.Chef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject.three_tier_architecture.PL.Chef
{
    public partial class UpdateShowcase : Form
    {

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private int imageNum = 0;

        public UpdateShowcase()
        {
            InitializeComponent();
        }

        private void cmb_selected_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            nud_quntity.Value = 0;
            DataSet data = new DataSet();
            BUpdateShowcase showcaseCheck = new BUpdateShowcase();


            data = showcaseCheck.checkShowCase(cmb_selected_item.SelectedItem.ToString());
            if(data != null)
            {
                DataTable tbl = data.Tables[0];

                try
                {
                    //might not need this part
                    foreach (DataRow row in tbl.Rows)
                    {
                        txt_item_name.Text =(row["ItemName"].ToString());
                        imageNum = Convert.ToInt32(row["itemImageNo"]);
                        nud_quntity.Value = Convert.ToInt32(row["Quantity"]);
                    }

                    btn_update_status.Text = "Add";

                    //end
                }
                catch (System.ArgumentException)
                {
                    foreach (DataRow row in tbl.Rows)
                    {
                        txt_item_name.Text =(row["ItemName"].ToString());
                        imageNum = Convert.ToInt32(row["ImageNo"]);
                        nud_quntity.Value = Convert.ToInt32(row["Quantity"]);
                    }

                    btn_update_status.Text = "Update";
                }
            }
            if(data == null)
            {
                btn_update_status.Text = "Add";
            }

            loadImage();
        }

        public void checkShowCaseForItems()
        {
            ItemImage imagesItems = new ItemImage();

            BUpdateShowcase showCheck = new BUpdateShowcase();
            DataSet data = new DataSet();
            data = showCheck.checkShowCase(cmb_selected_item.SelectedItem.ToString());
            

            if (data != null)
            {
                DataTable tbl = data.Tables[0];
                foreach (DataRow row in tbl.Rows)
                {
                    cmb_selected_item.Items.Add(row["itemName"].ToString());
                    imageNum = Convert.ToInt32(row["itemImageNo"]);
                }

                pb_item_image.Image = imagesItems.getItemImage(imageNum);
            }
            else
            {
                txt_item_name.Text = cmb_selected_item.SelectedText;
                TostMessage notFoundMessage = new TostMessage("No ShowCase Items found!","Not Found",1,1);
                notFoundMessage.Show();
            }
        }

        public void intComboBoxIteams()
        {

            BUpdateShowcase items = new BUpdateShowcase();
            DataSet ds = new DataSet();
            ds = items.getAvailableItems(true,null); 

            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    cmb_selected_item.Items.Add(row["itemName"].ToString());
                    imageNum = Convert.ToInt32(row["itemImageNo"]);
                }
            }
            else { }
        }

        private void UpdateShowcase_Load(object sender, EventArgs e)
        {
            intComboBoxIteams();
            cmb_selected_item.SelectedIndex = 0;
        }

        private void loadImage()
        {
            ItemImage getImage = new ItemImage();

            BUpdateShowcase items = new BUpdateShowcase();
            DataSet ds = new DataSet();
            string sel = cmb_selected_item.SelectedItem.ToString();
            ds = items.getAvailableItems(false,sel);

            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txt_item_name.Text = (row["itemName"].ToString());
                    imageNum = Convert.ToInt32(row["itemImageNo"]);
                }
                
                pb_item_image.Image = getImage.getItemImage(imageNum);
            }
            else { }
        }

        private void btn_update_status_Click(object sender, EventArgs e)
        {
            DUpdateShowcase setShowCase = new DUpdateShowcase();

            int stat = setShowCase.setShowCaseItem(txt_item_name.Text, imageNum, Convert.ToInt32(nud_quntity.Value));

            if (stat ==1)
            {
                TostMessage messageSucses = new TostMessage("ShowCase Item Successfully added", "Successful", 3, 3);
                messageSucses.Show();
            }
            else if (stat == 0)
            {
                TostMessage messageFail = new TostMessage("ShowCase Item adding failed", "Failed", 1, 1);
                messageFail.Show();
            }
            else if (stat ==-1)
            { 
                TostMessage messageError = new TostMessage("Unexpected Error Occurred", "Unexpected Error", 2, 2);
                messageError.Show();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("UpdateShowCase");
            this.Dispose();
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
