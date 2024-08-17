using FinalProject.three_tier_architecture.DAL.Supplier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Supplier
{
    public class BStockOrderRequest
    {
        public DataSet getRequests(bool allRequests)
        {
            DStockOrderRequest request = new DStockOrderRequest();
            return request.getRequests(allRequests);

        }

        public int setPrice(Decimal netPrice, string reqId)
        {
            DStockOrderRequest price = new DStockOrderRequest();
            return price.setPrice(netPrice, reqId);
        }

        public int setStat(string reqId, string reqStat)
        {
            DStockOrderRequest delivering = new DStockOrderRequest();
            return delivering.setPrice(reqId, reqStat);
        }
    }
}
