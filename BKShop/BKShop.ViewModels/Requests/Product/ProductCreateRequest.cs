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
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int BrandId { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Capacity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Range(1, 99, ErrorMessage = "Stock from {1} to {2}")]
        public int Stock { get; set; }

        public IFormFile Image { get; set; }
    }

}
