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
    public partial class RequestAssistant : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public RequestAssistant()
        {
            InitializeComponent();
        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            count = txt_description.Text.Length;
            lbl_no_of_letters.Text = $"{count}/500";
        }

        private void RequestAssistant_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            BRequestAssistant reqAssist = new BRequestAssistant();
            setComboBox(reqAssist.getTblNames());

            cmb_request_type.SelectedIndex = 0;
        }
        
        private void setComboBox(DataSet ds)
        {
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                cmb_tbl_names.Items.Add(row["Tid"].ToString());
            }
            cmb_tbl_names.SelectedIndex = 0;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            int stat = 0;

            if (cmb_request_type.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a request Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BRequestAssistant requAssist = new BRequestAssistant();
                if (CustomerHome.curruntCusId == "Guest" || CustomerHome.curruntCusId != null)
                {
                   stat= requAssist.addRequest(cmb_request_type.SelectedItem.ToString(),cmb_tbl_names.SelectedItem.ToString(),
                        CustomerHome.curruntCusId,txt_description.Text);
                }
                else if(CustomerHome.curruntCusId == null) 
                {
                    CustomerHome.curruntCusId = "Guest";
                    stat= requAssist.addRequest(cmb_request_type.SelectedItem.ToString(), cmb_tbl_names.SelectedItem.ToString(),
                        CustomerHome.curruntCusId, txt_description.Text);
                }

                if (stat == 0)
                {
                    TostMessage messFail = new TostMessage("Faild to Add Request","Faild",1,1);
                    messFail.Show();
                    clearUi();
                }
                else if(stat == 1) 
                {
                    TostMessage messSucc = new TostMessage("Successfully Added Request", "Successful",3,3);
                    messSucc.Show();
                    clearUi();
                }
                else if(stat == -1)
                {
                    TostMessage messUnexpec = new TostMessage("UnExpeceted Error","Error",2,2);
                    messUnexpec.Show();
                    clearUi();
                }
            }
        }

        private void clearUi()
        {
            txt_description.Clear();
            cmb_request_type.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("RequestAssistant");
            this.Dispose();
        }

        private void btn_close_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void btn_close_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
