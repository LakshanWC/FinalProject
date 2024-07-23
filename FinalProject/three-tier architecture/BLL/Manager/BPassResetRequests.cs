using FinalProject.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MVC.Control
{
    public  class BPassResetRequests
    {
        public DataSet getPassRequests() 
        {
            Model.DPassResetRequests passRequestObj = new Model.DPassResetRequests();
            return passRequestObj.getPassRequests();
        }

        public int updateSelectedRows(List<int> selectedRowIds)
        {
            Model.DPassResetRequests myRequest = new Model.DPassResetRequests();
            return myRequest.updateSelectedRows(selectedRowIds);
        }
    }
}
