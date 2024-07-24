using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BOrderFood
    {
        public DataSet getItemData(string itemId)
        {
            DOrderFood data = new DOrderFood();
            return data.getItemData(itemId);
        }
    }
}
