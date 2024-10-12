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
            ItemImage myImage = new ItemImage();
            BUpdateShowcase showC = new BUpdateShowcase();
            DataSet set = new DataSet();
            string name = cmb_selected_item.SelectedItem.ToString();
            set = showC.getAllDetails(name);

            if(set != null)
            {
                DataTable dt = set.Tables[0];
                foreach(DataRow dr in dt.Rows)
                {
                    imageNum = Convert.ToInt32(dr["itemImageNo"]);
                    nud_quntity.Value = Convert.ToDecimal(dr["showcaseItem"]);
                }

                txt_item_name.Text = name;
                pb_item_image.Image = myImage.getItemImage(imageNum);

            }
        }

        public void checkShowCaseForItems()
        {
            //need implement
        }

        public void intComboBoxIteams()
        {   
            BUpdateShowcase upShow = new BUpdateShowcase();
            DataSet results = new DataSet();

            results = upShow.getItems();
            if (results!=null)
            {
                DataTable dt = results.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    cmb_selected_item.Items.Add(dr["itemName"].ToString());
                }
            }

        }

        private void UpdateShowcase_Load(object sender, EventArgs e)
        {
            intComboBoxIteams();
            cmb_selected_item.SelectedIndex = 0;
        }


        private void loadImage()
        {
            //need to code
        }

        private void btn_update_status_Click(object sender, EventArgs e)
        {
            BUpdateShowcase showcase = new BUpdateShowcase();
            int stat = 0;
            stat = showcase.updateItems(txt_item_name.Text, Convert.ToInt32(nud_quntity.Value));

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


        //do not chagne 
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
