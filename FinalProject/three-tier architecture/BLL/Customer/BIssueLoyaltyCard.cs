using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BIssueLoyaltyCard
    {
        public int activeCard(string telNo)
        {
            DIssueLoyaltyCard active = new DIssueLoyaltyCard();
            return active.activeCard(telNo);
        }
    }
}
