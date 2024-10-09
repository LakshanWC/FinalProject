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

        public DataSet getAvailableItems(bool defaultSearch, string itName)
        {
            DataSet rst = new DataSet();
            rst = showCase.getAvailableItems(defaultSearch,itName);
            if(rst == null)
            {
                TostMessage tostFail = new TostMessage("No items found in Showcase", "Loaded", 1, 1);
                tostFail.Show();
                return null;
            }
            else
            {
                return rst;
            }
        }

        public DataSet checkShowCase(string item)
        {
            DataSet rstt = new DataSet();
            rstt = showCase.checkShowCase(item);
            if (rstt == null)
            {
                TostMessage tostFail = new TostMessage("No items found in Showcase", "Loaded", 1, 1);
                tostFail.Show();
                return null;
            }
            else
            {
                return rstt;
            }
        }
    }
}
