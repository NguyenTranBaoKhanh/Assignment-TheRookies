using BKShop.Application.Catalog.Products.Dtos;
using BKShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Catalog.Products
{
    public interface IManageProductService
    {
        int Create(ProductCreateRequest request);
        int Update(ProductEditRequest request);
        int Delete(int productId);
        List<ProductViewModel> GetAll();
        PageViewModel<ProductViewModel> GetAllPaging(string keyword, int pageIndex, int pageSize);

    }
}
