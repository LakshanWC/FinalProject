using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Sales_Finance
{
    public class BRemoveStock
    {
        public DataSet getStockNames()
        {
            //same method is in AddStock Ui code
            DAddNewStock names = new DAddNewStock();
            return names.getStockNames();
        }

        public DataSet getStockDetails(string stockName)
        {
            //same method is in AddStock Ui code
            DAddNewStock details = new DAddNewStock();
            return details.getStockDetails(stockName);
        }

        public int removeStock(string stockName)
        {
            DRemoveStock remove = new DRemoveStock();
            return remove.removeStock(stockName);
        }
    }
}
