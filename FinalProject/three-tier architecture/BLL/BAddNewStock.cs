using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL
{
    public class BAddNewStock
    {
        public int addnewStock(string stockName, int quntity)
        {
            DAddNewStock stock = new DAddNewStock();
            return stock.addnewStock(stockName, quntity);

        }

        public DataSet getStockNames()
        {
            DAddNewStock names = new DAddNewStock();
            return names.getStockNames();
        }
    }
}
