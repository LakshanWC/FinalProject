using FinalProject.three_tier_architecture.DAL.Sales_Finance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject.three_tier_architecture.BLL.Supplier
{
    public class BTransaction
    {
        public DataSet getPaymentPanding(bool loadAll)
        {
            DTransaction transaction = new DTransaction();
            return transaction.getPaymentPending(loadAll);
        }
    }
}
