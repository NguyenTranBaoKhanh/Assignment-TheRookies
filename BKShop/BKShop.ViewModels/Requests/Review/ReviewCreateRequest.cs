using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.Requests.Review
{
    public class ReviewCreateRequest
    {
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public int Star { get; set; }
    }
}
