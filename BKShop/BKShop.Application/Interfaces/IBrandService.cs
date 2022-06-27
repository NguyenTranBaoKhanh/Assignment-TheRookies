using BKShop.ViewModels.Requests.Brand;
using BKShop.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Interfaces
{
    public interface IBrandService
    {
        Task<int> CreateAsync(BrandCreateRequest request);

        Task<int> UpdateAsync(BrandUpdateRequest request);


        Task<int> DeleteAsync(int brandId);

        Task<List<BrandViewModel>> GetAllAsync();
        Task<BrandViewModel> GetByIdAsync(int brandId);
    }
}
