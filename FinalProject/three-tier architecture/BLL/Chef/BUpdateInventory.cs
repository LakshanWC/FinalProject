using FinalProject.three_tier_architecture.DAL.Chef;
using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Chef
{
    public class BUpdateInventory
    {
        public DataSet getStockNames()
        {
            DAddNewStock names = new DAddNewStock();
            return names.getStockNames();
        }


        public DataSet getStockDetails(string stockName)
        {
            DAddNewStock details = new DAddNewStock();
            return details.getStockDetails(stockName);
        }

        public int updateStockDetails(string stockName, int quantity, string stockStat)
        {
            DUpdateInventory update = new DUpdateInventory();
            return update.updateStockDetails(stockName, quantity, stockStat);
        }
    }
}
