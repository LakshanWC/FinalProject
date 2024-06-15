using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public class BLogin
    {
        DLogin mLogin = new DLogin();
        public int checkLogin(string username, string password)
        {     
            int status = mLogin.CheckLogin(username, password);
            if (status == 0 ) return 0;
            else return status;
        }
        public void markAttendant(string username) { 
            mLogin.markAttendant(username);
        }
    }
}
