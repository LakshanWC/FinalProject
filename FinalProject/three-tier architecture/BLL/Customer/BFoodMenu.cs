using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BFoodMenu
    {
        public DataSet getMenuItems() 
        {
            DFoodMenu menu = new DFoodMenu();
            return menu.getMenuItems();
        }
    }
}
