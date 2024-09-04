using FinalProject.MVC.Model;
using FinalProject.MVC.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public class BManagerHome_All
    {
        DManagerHome_All dmHome = new DManagerHome_All();

        public int getPasswordResetRequests()
        {
            Model.DManagerHome_All mhomeObj = new Model.DManagerHome_All();
            return mhomeObj.getPasswordResetRequests();
        }

        public int noOfEmployees()
        {
            return dmHome.noOfEmployees();
        }

        public decimal getIncome()
        {
            return dmHome.getIncome();
        }
        public int getCustomerSatis()
        {
            return dmHome.getCustomerSatis();
        }
        public DataSet getEvents()
        {
            return dmHome.getEvents();
        }
    }
}
