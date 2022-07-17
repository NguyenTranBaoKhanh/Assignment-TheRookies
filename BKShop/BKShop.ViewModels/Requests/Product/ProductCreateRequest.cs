using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BKShop.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.Requests.Product
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Color { get; set; }
        public string Capacity { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        [Range(1, 99, ErrorMessage = "Stock from {1} to {2}")]
        public int Stock { get; set; }
        public string Group { get; set; }
        public string? Image { get; set; }
    }

}
