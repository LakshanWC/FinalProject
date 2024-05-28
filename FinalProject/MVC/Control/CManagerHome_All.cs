using FinalProject.MVC.Model;
using FinalProject.MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public class CManagerHome_All
    {
        
        public int getPasswordResetRequests() 
        {
            ManagerHome_All mhomeObj = new ManagerHome_All();
            return mhomeObj.getPasswordResetRequests();
        }
    }
}
