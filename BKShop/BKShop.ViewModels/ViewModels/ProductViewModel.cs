using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Capacuty { get; set; }
        public string Stock { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}
