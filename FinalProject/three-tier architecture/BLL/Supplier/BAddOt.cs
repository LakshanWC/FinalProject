using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Supplier
{
    public class BAddOt
    {
        DAddOt overTime = new DAddOt();

        public DataSet getUserNames()
        {
            return overTime.getUserNames();
        }
        public bool setOT(decimal otHours, string userName)
        {
            return overTime.setOT(otHours, userName);
        }
        public DataSet getUserDetails(string userName)
        {
            return overTime.getUserDetails(userName);
        }
    }
}
