using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.Requests.Image
{
    public class ImageCreateRequest
    {
        public IFormFile files { get; set; }
    }
}
