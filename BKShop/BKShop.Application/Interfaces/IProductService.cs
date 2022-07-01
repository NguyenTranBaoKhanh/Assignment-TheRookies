using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BKShop.ViewModels.Common;
using BKShop.ViewModels.Requests.Product;
using BKShop.ViewModels.ViewModels;

namespace BKShop.Application.Interfaces
{
    public interface IProductService
    {
        Task<int> CreateAsync(ProductCreateRequest request);

        Task<int> UpdateAsync(ProductUpdateRequest request);

        Task<int> DeleteAsync(int ProductId);
        Task<List<ProductViewModel>> GetAllAsync();

        Task<List<ProductViewModel>> GetTop5Async();

        Task<List<ProductViewModel>> GetByCategoryAsync(int categoryId);
        Task<List<ProductViewModel>> GetByBrandAsync(int brandId);

        Task<List<ProductViewModel>> GetByColorAndGroupAsync(string color, string group);

        Task<List<ProductViewModel>> GetByCategoryByBrandAsync(int categoryId, int brandId);

        Task<List<ArrayViewModel>> GetColorByGroupAsync(string group);

        Task<ProductViewModel> GetByIdAsync(int productId);
        Task<List<ProductViewModel>> GetByAccessoryAsync();

        Task<PagedResult<ProductViewModel>> GetAllPagingAsync(GetProductPagingRequest request);

        Task<List<ProductViewModel>> GetLatestProduct();

        Task<int> AddComment(int productId, string comment, Guid user);

        
    }
}
