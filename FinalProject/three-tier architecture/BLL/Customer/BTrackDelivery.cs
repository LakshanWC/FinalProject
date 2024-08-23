using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BTrackDelivery
    {
        public DataSet getDeliveryOrders(string oId,bool isNormal)
        {

            DTrackDelivery deliveryOrders = new DTrackDelivery();
            return deliveryOrders.getDeliveryOrders(oId,isNormal);
        }

        public string getOrderDeliverStat(string oId, bool isNormalOrder)
        {
            DTrackDelivery set = new DTrackDelivery();
            return set.getOrderDeliverStat(oId, isNormalOrder);
        }
    }
}
