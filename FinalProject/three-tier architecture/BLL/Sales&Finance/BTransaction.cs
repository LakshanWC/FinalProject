using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Sales_Finance
{
    public class BTransaction
    {
        public DataSet getPaymentPanding(bool loadAll)
        {
            DTransaction transaction = new DTransaction();
            return transaction.getPaymentPending(loadAll);
        }

        public int setAsPaid(string reqId)
        {
            DTransaction paid = new DTransaction();
            return paid.setAsPaid(reqId);
        }

        public DataSet getAllPaid()
        {
            DTransaction transaction = new DTransaction();
            return transaction.getAllPaid();
        }
    }
}
