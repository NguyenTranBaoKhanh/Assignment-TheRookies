using BKShop.Application.Catalog.Products.Dtos;
using BKShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
