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
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
        [Required]
        [Range(1, 99, ErrorMessage = "Stock from {1} to {2}")]
        public int Stock { get; set; }

        public IFormFile FileUploads { get; set; }
    }

}
