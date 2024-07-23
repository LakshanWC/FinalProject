using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BCustomerHome
    {
        public string getUserId(string userName) 
        {
            DCustomerHome uId = new DCustomerHome();
            return uId.getUserId(userName);
        }
    }
}
