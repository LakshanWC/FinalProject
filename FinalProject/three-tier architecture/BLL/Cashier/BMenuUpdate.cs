using FinalProject.three_tier_architecture.DAL.Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Cashier
{
    public class BMenuUpdate
    {
        public int updateMenuItem(string itemName, string price, string calories)
        {
            DMenuUpdate menu = new DMenuUpdate();
            return menu.updateMenuItem(itemName, price, calories);
        }
    }
}
