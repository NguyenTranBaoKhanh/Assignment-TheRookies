using BKShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? CreatedDate { get; set; }


    }


}
