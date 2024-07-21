using FinalProject.three_tier_architecture.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.three_tier_architecture.BLL
{
    public class BAddItem
    {
        public int addItem(  string itemName, double itemPrice, int itemType, int itemCalories, string itemDescription,int imageNo) { 

            DAddItem addNewItem = new DAddItem();
            return addNewItem.addItem(itemName, itemPrice, itemType, itemCalories, itemDescription,imageNo);
        }
        public int getItemId() 
        {
            DAddItem itemId = new DAddItem();
            return itemId.getItemId();
        }
    }

}
