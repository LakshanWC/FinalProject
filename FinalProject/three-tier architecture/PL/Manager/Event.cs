using FinalProject.MVC;
using FinalProject.three_tier_architecture.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.three_tier_architecture.PL
{
    public partial class Event : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        //set variables for ui

        string eventName;
        string eventOrganizer;
        int eventType;
        int eventStatus;
        string eventDescription;
        string startDate;
        string endDate;
        string startTime;
        string endTime;


        public Event()
        {
            InitializeComponent();
        }

        private void txt_event_description_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            count = txt_event_description.Text.Length;
            lbl_word_count.Text = $"{count}/500";
        }

        private void txt_event_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (txt_event_description.Text.Length >= 500)
            {
                e.Handled = true;
            }
        }

        private void btn_add_event_Click(object sender, EventArgs e)
        {
            eventName = txt_event_title.Text;
            eventOrganizer = txt_organizer_name.Text;
            eventType = cmb_event_type.SelectedIndex;
            eventStatus = cmb_event_status.SelectedIndex;
            eventDescription = txt_event_description.Text;

            //take just the date
            startDate = dtp_start_date.Value.ToString("yyyy-MM-dd");
            endDate = dtp_end_date.Value.ToString("yyyy-MM-dd");

            //take just the time
            startTime = dtp_start_time.Value.ToString("HH:mm:ss");
            endTime = dtp_end_time.Value.ToString("HH:mm:ss");

            if (!string.IsNullOrEmpty(txt_event_title.Text) && !string.IsNullOrEmpty(txt_organizer_name.Text)
                && !string.IsNullOrEmpty(txt_event_description.Text) && cmb_event_type.SelectedIndex != 0
                && dtp_end_time.Value != dtp_start_time.Value)
            {

                BEvent newEvent = new BEvent();
               int status = newEvent.addNewEvent(eventName, eventOrganizer, eventType, eventStatus
                ,eventDescription, startDate, endDate, startTime, endTime);

                if (status ==1) {
                    clearUi();
                    TostMessage messageSucses = new TostMessage("Item Successfully added", "Successful", 3, 3);
                    messageSucses.Show();
                }
                else if (status == 0) {
                    clearUi();
                    TostMessage messageFail = new TostMessage("Item adding failed", "Failed", 1, 1);
                    messageFail.Show();
                }
                else if(status ==-1) {
                    clearUi();
                    TostMessage messageError = new TostMessage("Unexpected Error Occurred", "Unexpected Error", 2, 2);
                    messageError.Show();
                }

            }
            else { 
                MessageBox.Show("All fields must be filed","Warrning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearUi();
        }

        private void clearUi() {
            txt_event_title.Clear();
            txt_organizer_name.Clear();
            cmb_event_type.SelectedIndex = 0;
            cmb_event_status.SelectedIndex = 0;
            txt_event_description.Clear();

            dtp_start_date.Value = DateTime.Now;
            dtp_end_date.Value = DateTime.Now;
            dtp_start_time.Value = DateTime.Now;
            dtp_end_time.Value = DateTime.Now;

        }

        private void Event_Load(object sender, EventArgs e)
        {
            cmb_event_status.SelectedIndex = 0;
            cmb_event_type.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
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
