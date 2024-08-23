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

        public int checkCard(string cardTelNo)
        {
            DOrderFood food = new DOrderFood();
            return food.checkCard(cardTelNo);
        }
        public string generateUniqueString()
        {
            DOrderFood genId = new DOrderFood();
            return genId.generateUniqueString();
        }
        public bool addOrder(int orderQuantity, DateTime createdDate, string orderStatus, string cNo,
                   string itemName, string uniqueKey, decimal totPrice, string Tid,string deliveryStat)
        {
            DOrderFood order = new DOrderFood();
            return order.addOrder(orderQuantity, createdDate, orderStatus, cNo, itemName, uniqueKey, totPrice, Tid, deliveryStat);
        }

        public DataSet getAvailableTbls()
        {
            DOrderFood tabls = new DOrderFood();
            return tabls.getAvailableTbls();
        }

        public string getNoOfSeats(string tblName)
        {
            DOrderFood seats = new DOrderFood();
            return seats.getNoOfSeats(tblName);
        }
    }
}
