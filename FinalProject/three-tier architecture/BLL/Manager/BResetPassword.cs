using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public class BResetPassword
    {


        public Boolean resetPassword(string username, string password)
        {
            DResetPassword mResetPassword = new DResetPassword();
            Boolean status = mResetPassword.resetPassword(username, password);
            if (status == true) return true;
            else return false;
        }
        public bool requestExist(string username)
        {
            DResetPassword mResetPass = new DResetPassword();
            Boolean status = mResetPass.requestExist(username);
            if (status == true) return true;
            else return false;
        }

        public int updatePassword(string username, string password)
        {
            DResetPassword passCUstom = new DResetPassword();
            return passCUstom.updatePassword(username, password);
        }
    }
}
