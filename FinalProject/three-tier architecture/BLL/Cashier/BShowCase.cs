using FinalProject.three_tier_architecture.DAL.Cashier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Cashier
{
    public class BShowCase
    {
        DShowCase showCaseItem = new DShowCase();

        public DataSet getShowCaseItemNames()
        {
            DataSet ds = new DataSet();
            ds = showCaseItem.getShowCaseItemNames();
            return ds;
        }

        public DataSet getMenuItemPriceAndCalories(string name)
        {
            return showCaseItem.getMenuItemPriceAndCalories(name);
        }
    }
}
