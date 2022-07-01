using BKShop.ViewModels.ViewModels;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ApiIntegration.Interfaces
{
    public interface IProductApi
    {
        [Get("/api/Product")]
        Task<List<ProductViewModel>> GetAllAsync();

        [Get("/api/Product/{Id}")]
        Task<ProductViewModel> GetByIdAsync(int Id);

        [Get("/api/Product/Top5")]
        Task<List<ProductViewModel>> GetTop5Async();

        [Get("/api/Product/Category/{Id}")]
        Task<List<ProductViewModel>> GetByCategoryAsync(int Id);

        [Get("/api/Product/{categoryId}/{brandId}")]
        Task<List<ProductViewModel>> GetByCategoryByBrandAsync(int categoryId, int brandId);

        [Get("/api/Product/Accessory")]
        Task<List<ProductViewModel>> GetByAccessoryAsync();

        [Get("/api/Product/Color/{Color}/{Group}")]
        Task<List<ProductViewModel>> GetByColorAndGroupAsync(string Color, string Group);
        
        [Get("/api/Product/Color/{Group}")]
        Task<List<ArrayViewModel>> GetColorByGroupAsync(string Group);
    }
}
