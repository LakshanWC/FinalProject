using FinalProject.three_tier_architecture.DAL.Customer;
using FinalProject.three_tier_architecture.DAL.Waiter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Waiter
{
    public class BCustomerRequests
    {
        public DataSet getRequestData(string type)
        {
            DCustomerRequests req = new DCustomerRequests();
            return req.getRequestData(type);
        }
    }
}
