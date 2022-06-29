using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.Requests.Product
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Color { get; set; }
        public string Capacity { get; set; }
        public decimal? Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
