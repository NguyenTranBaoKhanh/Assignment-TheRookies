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
        [Get("/api/Category")]
        Task<List<ProductViewModel>> GetAllAsync();
    }
}
