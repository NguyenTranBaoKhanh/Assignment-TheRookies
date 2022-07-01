using BKShop.ViewModels.ViewModels;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ApiIntegration.Interfaces
{
    public interface IBrandApi
    {
        [Get("/api/Brand")]
        Task<List<BrandViewModel>> GetAllAsync();

        [Get("/api/Brand/{Id}")]
        Task<BrandViewModel> GetByIdAsync(int Id);
    }
}
