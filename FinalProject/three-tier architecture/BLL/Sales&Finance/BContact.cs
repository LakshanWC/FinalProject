using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Sales_Finance
{
    public class BContact
    {
        public DataSet getStockNames()
        {
            BAddNewStock stock = new BAddNewStock();
            return stock.getStockNames();
        }

        public int setRequest(string inName, int reqQuantity, DateTime requestDate, string description,
       string requestStatus, DateTime deliveryOn)
        {
            DContact request = new DContact();
            return request.setRequest(inName, reqQuantity, requestDate, description, requestStatus, deliveryOn);
        }
    }
}
