using FinalProject.three_tier_architecture.DAL;
using FinalProject.three_tier_architecture.DAL.Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Manager
{
    public class BRemoveMenuItem
    {
        DRemoveMenuItem remEmp = new DRemoveMenuItem();

        public DataSet getMenuItemsData(string itemName)
        {
            return remEmp.getMenuItemsData(itemName);
        }
        public DataSet getItemNames()
        {
            return remEmp.getItemNames();
        }
        public bool deleteMenuItem(string itemName)
        {
            return remEmp.deleteMenuItem(itemName);
        }

    }
}
