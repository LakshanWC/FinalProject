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
        public DataSet getOrders()
        {
            DDelivery delivery = new DDelivery();
            return delivery.getOrders();
        }
        public DataSet getSpecialOrders()
        {
            DDelivery delivery = new DDelivery();
            return delivery.getSpecialOrders();
        }
    }
}
