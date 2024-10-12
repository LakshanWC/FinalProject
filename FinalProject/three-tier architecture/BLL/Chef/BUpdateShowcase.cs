using FinalProject.MVC;
using FinalProject.three_tier_architecture.DAL.Chef;
using FinalProject.three_tier_architecture.PL.Chef;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Chef
{
    public class BUpdateShowcase
    {
        DUpdateShowcase showCase = new DUpdateShowcase();

        public DataSet getItems()
        {
            return showCase.getItems();
        }

        public DataSet getAllDetails(string name)
        {
            return showCase.getAllDetails(name);
        }

        public int updateItems(string name, int quantity)
        {
            return showCase.updateItems(name, quantity);
        }
    }
}
