using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        //public List<Order> Orders { get; set; }
        //public List<Cart> Carts { get; set; }


    }
}
