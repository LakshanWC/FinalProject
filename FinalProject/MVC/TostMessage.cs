using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.MVC
{
    public partial class TostMessage : Form
    {
        int tostX, tostY;

        public TostMessage()
        {
            InitializeComponent();
        }

        private Image icon_info = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Tost_Message_icons\\info_icon.jpg");
        private Image icon_error = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Tost_Message_icons\\error_icon.jpg");
        private Image icon_warrning = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Tost_Message_icons\\info_icon.jpg");
        private Image icon_question = Image.FromFile("D:\\Nibm\\C# projects\\FinalProject\\icons & images\\Tost_Message_icons\\question_icon.jpg");


        public TostMessage (string message,string title,int color,int icon)
        {
            InitializeComponent();
            tost_title.Text = title;
            tost_message.Text = message;
            switch (color)
            {
                case 1:
                    tost_color.BackColor = Color.Orange;
                    break;
                case 2:
                    tost_color.BackColor = Color.Red;
                    break;
                case 3:
                    tost_color.BackColor = Color.Yellow;
                    break;
                default:
                    tost_color.BackColor= Color.Blue;
                    break;
            }
            switch (icon)
            {
                case 1:
                    tost_icon.BackgroundImage = icon_info;
                    break;
                case 2:
                    tost_icon.BackgroundImage= icon_error;
                    break;
                case 3:
                    tost_icon.BackgroundImage = icon_warrning;
                    break;
                default :
                    tost_icon.BackgroundImage = icon_question;
                    break;
            }
            
        }

        private void TostMessage_Load(object sender, EventArgs e)
        {
            toastTimer();
        }

        private void position() 
        { 
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenheight = Screen.PrimaryScreen.WorkingArea.Height;

            tostX = screenWidth - this.Width;
            tostY = screenheight - this.Height;

            this.Location = new Point(tostX, tostY);
        }
        private void toastTimer()
        { 
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            position();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Close the form when the timer ticks (after 10 seconds)
            Close();
        }
    }
}
