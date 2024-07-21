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
        private bool loadEventById = false;
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
                    TostMessage messageSucses = new TostMessage("Event Successfully added", "Successful", 3, 3);
                    messageSucses.Show();
                }
                else if (status == 0) {
                    clearUi();
                    TostMessage messageFail = new TostMessage("Event adding failed", "Failed", 1, 1);
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
            cb_laod_event_by_id.Enabled = false;

            BEvent eventId = new BEvent();
            txt_event_no.Text = Convert.ToString("0"+eventId.getEventId());

            DataSet todaysEvent = eventId.getEventNames(loadEventById);

            if (todaysEvent == null || todaysEvent.Tables.Count == 0 || todaysEvent.Tables[0].Rows.Count == 0)
            {
                TostMessage messageFail = new TostMessage("No upcoming events found.", "Failed", 1, 1);
                messageFail.Show();
            }
            else
            {
                foreach (DataRow row in todaysEvent.Tables[0].Rows)
                {
                    cmb_search_event.Items.Add(row["Ename"].ToString());
                }
                cmb_search_event.SelectedIndex = 0;
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NewManagerHome.opendChildForms.Remove("Event");
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

        private void cb_load_all_events_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_load_all_events_Click(object sender, EventArgs e)
        {
            BEvent allEvents = new BEvent();
            DataSet ds = allEvents.getAllEvents(loadEventById);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                TostMessage messageFail = new TostMessage("No upcoming events found.", "Failed",1, 1);
                messageFail.Show();
            }
            else
            {

                if (checkForDuplicateValues(ds) == true)
                {
                    cmb_search_event.Items.Clear();
                    ds = allEvents.getAllEvents(true);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        cmb_search_event.Items.Add(row["Eid"].ToString());
                    }
                    cmb_search_event.SelectedIndex = 0;
                    cb_laod_event_by_id.Enabled = false;
                    cb_laod_event_by_id.Checked = true;

                    TostMessage messageFail = new TostMessage("Duplicate events found. Loading by ID.", "Warning", 1, 1);
                    messageFail.Show();

                }
                else if (checkForDuplicateValues(ds) == false) 
                {
                    cmb_search_event.Items.Clear();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        cmb_search_event.Items.Add(row["Ename"].ToString());
                    }
                    cmb_search_event.SelectedIndex = 0;
                }
            }
            
        }


        //method to check if there are events with the same name

        private bool checkForDuplicateValues(DataSet data)
        {
            HashSet<string> seenValues = new HashSet<string>();

            foreach (DataRow row in data.Tables[0].Rows)
            {
                string value = row["Ename"].ToString();
                if (!seenValues.Add(value)) // Add returns false if the value is already in the set
                {
                    return true; // Duplicate found
                }
            }

            return false; // No duplicates found
        }


        private void cb_laod_event_by_id_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_laod_event_by_id.Checked) 
            { 
                loadEventById = true;
            }
            else { loadEventById = false; }
        }

        private void btn_update_event_Click(object sender, EventArgs e)
        {
            eventName = txt_event_title.Text;
            eventOrganizer = txt_organizer_name.Text;
            eventType = cmb_event_type.SelectedIndex;
            eventStatus = cmb_event_status.SelectedIndex;
            eventDescription = txt_event_description.Text;
            int eventId = Convert.ToInt32(cmb_search_event.SelectedItem.ToString());

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
                int status = newEvent.updateEvent(eventId,eventName, eventOrganizer, eventType, eventStatus
                 , eventDescription, startDate, endDate, startTime, endTime);

                if (status ==1)
                {
                    clearUi();
                    TostMessage messageSucses = new TostMessage("Event Successfully Updated", "Successful", 3, 3);
                    messageSucses.Show();
                }
                else if (status == 0)
                {
                    clearUi();
                    TostMessage messageFail = new TostMessage("Event updating failed", "Failed", 1, 1);
                    messageFail.Show();
                }
                else if (status ==-1)
                {
                    clearUi();
                    TostMessage messageError = new TostMessage("Unexpected Error Occurred", "Unexpected Error", 2, 2);
                    messageError.Show();
                }

            }
            else
            {
                MessageBox.Show("All fields must be filed", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_search_event_Click(object sender, EventArgs e)
        {

        }
    }
}
