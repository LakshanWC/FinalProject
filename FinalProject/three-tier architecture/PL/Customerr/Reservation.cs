using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL.Customer;
using FinalProject.three_tier_architecture.DAL.Customer;
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
    public partial class Reservation : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            cmb_type.SelectedIndex = 0;
            setSeats(cmb_type.SelectedIndex);
        }

        private void setSeats(int seatsNo)
        {
            BReservation reserv = new BReservation();
            DataSet dataSet = new DataSet();

            if(seatsNo == 0){ seatsNo = 2; }
            else if(seatsNo == 1){ seatsNo = 4; }
            else if(seatsNo == 2){ seatsNo = 6; }
            else if(seatsNo == 3){ seatsNo = 8; }

            dataSet = reserv.getAvailableTables(seatsNo);
            if(dataSet != null)
            {
                DataTable dt = dataSet.Tables[0];
                
                foreach(DataRow row in dt.Rows)
                {
                    cmb_selected_item.Items.Add(row["Tid"].ToString());
                }

                cmb_selected_item.SelectedIndex = 0;
            }
            else if(dataSet == null)
            {
                TostMessage messFail = new TostMessage("No Available Seats !","Warning",1,1);
                messFail.Show();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("Reservation");
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_selected_item.Items.Clear();
            setSeats(cmb_type.SelectedIndex);
        }

        private void btn_view_review_two_Click(object sender, EventArgs e)
        {
            BReservation rev = new BReservation();
            bool isSucc = rev.updateTblStat(cmb_selected_item.SelectedItem.ToString(),dtp_get_date.Value,dtp_get_time.Value);

            if (isSucc)
            {
                TostMessage messSucc = new TostMessage("Reservation Added","Success",3,3);
                messSucc.Show();
            }
            else
            {
                TostMessage messFail = new TostMessage("Faild To add Resevation","Faild",1,2);
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
