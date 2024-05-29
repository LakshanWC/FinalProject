using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public  class CPassResetRequests
    {
        public DataSet getPassRequests() 
        {
            MPassResetRequests passRequestObj = new MPassResetRequests();
            return passRequestObj.getPassRequests();
        }
    }
}
