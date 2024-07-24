using FinalProject.three_tier_architecture.DAL.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL.Customer
{
    public class BReview
    {
        public string getItemName(string itemId)
        {
            DReview getName = new DReview();
            return getName.getItemName(itemId);
        }
        public DataSet getReviewData(string itemName)
        {
            DReview reviews = new DReview();
            return reviews.getReviewData(itemName);
        }
        public DataSet getAllReviewItemNames()
        {
            DReview data = new DReview();
            return data.getAllReviewItemNames();
        }
        public int getReviewCount(string itemName)
        {
            DReview rowCount = new DReview();
            return rowCount.getReviewCount(itemName);
        }
    }
}
