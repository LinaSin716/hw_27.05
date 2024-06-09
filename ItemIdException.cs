using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_27._05
{
    public class ItemIdException : Exception
    {
        public ItemIdException(string message) :base(message) { }
    }
}
