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

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
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
    }
}
