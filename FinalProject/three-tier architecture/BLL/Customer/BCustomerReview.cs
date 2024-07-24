using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BCustomerReview
    {
        public DataSet getItemNames()
        {
            DCustomerReview names = new DCustomerReview();
            return names.getItemNames();
        }
        public int addReview(string cusId, string itemName, int reviewScore, string comment)
        {
            DCustomerReview review = new DCustomerReview();
            return review.addReview(cusId, itemName, reviewScore, comment);
        }
    }
}
