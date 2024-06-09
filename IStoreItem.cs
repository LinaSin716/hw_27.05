using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_27._05
{
    public interface IStoreItem
    {
        string ItemId { get; set; }
        decimal Price { get; set; }
    }
}
