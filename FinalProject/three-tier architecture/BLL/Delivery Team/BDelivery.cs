using FinalProject.three_tier_architecture.DAL.Delivery_Team;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Delivery_Team
{
    public class BDelivery
    {
        DDelivery delivery = new DDelivery();

        public DataSet getOrders()
        {
            return delivery.getOrders();
        }
        public DataSet getSpecialOrders()
        {
            return delivery.getSpecialOrders();
        }

        public int updateDeliveryStatus(string oid, string itemName, bool orderType, string deliveryStat)
        {
            return delivery.updateDeliveryStatus(oid, itemName, orderType, deliveryStat);
        }

        public bool setDeliveryLog(string userName, string oid, string itemName, string deliveryStatus, bool isNormalOrder)
        {
            return delivery.setDeliveryLog(userName, oid, itemName, deliveryStatus, isNormalOrder);
        }

        public int updateDeliveryTemp(string oid, string itemName, bool orderType, string deliveryStat)
        {
            return delivery.updateDeliveryTemp(oid, itemName, orderType, deliveryStat);
        }


        public DataSet getAcceptedDelivery()
        {
           return delivery.getAcceptedDelivery();
        }
    }
}
