using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_27._05
{
    public class StoreItem : IStoreItem
    {
        public string ItemId { get; set; }
        public decimal Price { get; set; }
        public StoreItem(string ItemId, decimal Price)
        {
            this.ItemId = ItemId;
            this.Price = Price;
        }
    }
}
