using FinalProject.MVC.Model;
using FinalProject.MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public class BManagerHome_All
    {
        
        public int getPasswordResetRequests() 
        {
            Model.DManagerHome_All mhomeObj = new Model.DManagerHome_All();
            return mhomeObj.getPasswordResetRequests();
        }
    }
}
