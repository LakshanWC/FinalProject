using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public class CResetPassword
    {
        

        public Boolean resetPassword(string username, string password)
        {
            MResetPassword mResetPassword = new MResetPassword();
            Boolean status = mResetPassword.resetPassword(username, password);
            if (status == true) return true;
            else return false;
        }
        public bool requestExist(string username) {
            MResetPassword mResetPass = new MResetPassword();
            Boolean status = mResetPass.requestExist(username);
            if (status == true) return true;
            else return false;
        }
    }
}
