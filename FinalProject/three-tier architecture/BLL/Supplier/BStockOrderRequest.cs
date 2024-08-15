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
    }
}
