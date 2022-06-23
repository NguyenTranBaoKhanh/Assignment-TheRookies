using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Utilities.Exceptions
{
    public class BKShopException : Exception
    {
        public BKShopException()
        {
        }

        public BKShopException(string message)
            : base(message)
        {
        }

        public BKShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
