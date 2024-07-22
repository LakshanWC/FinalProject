using FinalProject.three_tier_architecture.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL
{
    public class BRegisterForLoyaltyCard
    {
        public int addLoyaltyCard(string customerId, string cardHolderName, string telNo, DateTime createdDate)
        {
            DRegisterForLoyaltyCard newLoyaltyCard = new DRegisterForLoyaltyCard();
            return newLoyaltyCard.addLoyaltyCard(customerId, cardHolderName, telNo, createdDate);
        }
    }
}
