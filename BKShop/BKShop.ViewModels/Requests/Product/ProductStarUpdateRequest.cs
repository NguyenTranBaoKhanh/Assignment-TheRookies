using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.Requests.Product
{
    public class ProductStarUpdateRequest
    {
        public int productId { get; set; }
        public double Stars { get; set; }
    }
}
