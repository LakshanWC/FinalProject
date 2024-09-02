using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BRequestAssistant
    {
        DRequestAssistant reqAssist = new DRequestAssistant();

        public DataSet getTblNames()
        {
            return reqAssist.getTblNames();
        }

        public int addRequest(string reqType, string tblNo, string reqestBy, string reqestDetails)
        {
            return reqAssist.addRequest(reqType, tblNo, reqestBy, reqestDetails);
        }
    }
}
