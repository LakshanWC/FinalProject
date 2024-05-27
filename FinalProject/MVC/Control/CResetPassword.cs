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
        MResetPassword mResetPassword = new MResetPassword();

        public Boolean resetPassword(string username, string password)
        {
            Boolean status = mResetPassword.resetPassword(username, password);
            if (status == true) return true;
            else return false;
        }
        public bool requestExist(string username) {
            Boolean status = mResetPassword.requestExist(username);
            if (status == true) return true;
            else return false;
        }
    }
}
