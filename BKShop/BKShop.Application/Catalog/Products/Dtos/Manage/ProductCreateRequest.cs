using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Catalog.Products.Dtos.Manage
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Capacity { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }

        public int BrandId { get; set; }


    }
}
