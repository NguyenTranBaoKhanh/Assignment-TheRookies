using BKShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ViewModels.Requests.Product
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string? Keyword { get; set; }
        public List<int>? CategoryIds { get; set; }
    }
}
