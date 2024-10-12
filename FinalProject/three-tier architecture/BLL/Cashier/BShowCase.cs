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
            return showCaseItem.getShowCaseItemNames();
        }
    }
}
