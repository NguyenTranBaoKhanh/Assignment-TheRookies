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
    }
}
