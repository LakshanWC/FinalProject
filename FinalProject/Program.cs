using FinalProject.MVC.View;
using FinalProject.three_tier_architecture.PL;
using FinalProject.three_tier_architecture.PL.Chef;
using FinalProject.three_tier_architecture.PL.Customerr;
using FinalProject.three_tier_architecture.PL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new OrderConfirmation());
        }
    }
}
