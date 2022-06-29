using BKShop.Application.Catalog.Products.Dtos;
using BKShop.Application.Catalog.Products.Dtos.Manage;
using BKShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);

    }
}
