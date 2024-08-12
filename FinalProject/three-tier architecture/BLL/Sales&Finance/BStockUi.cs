using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Sales_Finance
{
    public class BStockUi
    {
        public DataSet getStockData()
        {
            DStockUi data = new DStockUi();
            return data.getStockData();
        }
        public DataSet getStockNames()
        {
            DAddNewStock names = new DAddNewStock();
            return names.getStockNames();
        }
    }
}
