using FinalProject.three_tier_architecture.DAL.Chef;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Chef
{
    public class BReceivedOrder
    {
        public DataSet getOrders()
        {
            DReceivedOrder order = new DReceivedOrder();
            return order.getOrders();
        }
    }
}
