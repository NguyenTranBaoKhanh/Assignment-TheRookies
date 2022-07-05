using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.Requests.Review
{
    public class ReviewUpdateRequest
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Star { get; set; }
    }
}
