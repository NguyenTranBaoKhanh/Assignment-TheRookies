using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Capacity { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Group { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate {get; set; }

        public List<Review> Reviews { get; set; }




    }
}
