using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Data.Entities
{
    public class Cart
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
