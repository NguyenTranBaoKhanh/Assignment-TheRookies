using BKShop.ViewModels.ViewModels;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ApiIntegration.Interfaces
{
    public interface ICategoryApi
    {
        [Get("/api/Category")]
        Task<List<CategoryViewModel>> GetAllAsync();

        [Get("/api/Category/{Id}")]
        Task<CategoryViewModel> GetByIdAsync(int Id);

        [Get("/api/Category/Accessory")]
        Task<List<CategoryViewModel>> GetAccessoryAsync();

    }
}
