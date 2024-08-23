using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BOrderCustomize
    {
        public int addSpecialOrder(int orderQuantity, DateTime createdDate, string orderStatus,
            string itemName, string uniqueKey, decimal totPrice, string extraItem1, string extraItem2,
            string extraItem3, string SORdetails,string deliverStat)
        {
            DOrderCustomize customize = new DOrderCustomize();
            return customize.addSpecialOrder(orderQuantity, createdDate, orderStatus, itemName, uniqueKey,
                totPrice, extraItem1, extraItem2, extraItem3, SORdetails,deliverStat);
        }
    }
}
