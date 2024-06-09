using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_27._05
{
    public class StoreInventory
    {
        public List<StoreItem> items = new List<StoreItem>();
        public void AddItem(StoreItem storeItem)
        {
            if (items.Any(i => i.ItemId == storeItem.ItemId)) 
            {
                throw new ItemIdException($"Товар с ItemId = {storeItem.ItemId} уже существует");
            }
            items.Add(storeItem);
        }
        public void RemoveItem(string itemId)
        {
            items.Remove(FindByItemId(itemId));
        }
        public StoreItem FindByItemId(string itemId) 
        {
            if (items.All(i => i.ItemId != itemId))
            {
                throw new ItemIdException($"Товара с ItemId = {itemId} не существует");
            }
            return items.Where(i => i.ItemId == itemId).FirstOrDefault();
        }
        public void NewPrice(string ItemId, decimal Price)
        {
            FindByItemId(ItemId).Price = Price;
        }
    }
}
