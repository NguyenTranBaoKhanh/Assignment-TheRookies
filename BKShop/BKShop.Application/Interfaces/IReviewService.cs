using BKShop.ViewModels.Requests.Review;
using BKShop.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Interfaces
{
    public interface IReviewService
    {
        Task<List<ReviewViewModel>> GetAllAsync();
        Task<ReviewViewModel> GetByIdAsync(int Id);
        Task<List<ReviewViewModel>> GetByUserIdAsync(Guid userId);
        Task<List<ReviewViewModel>> GetByProductIdAsync(int productId);
        Task<int> CreateAsync(ReviewCreateRequest request);
        Task<int> UpdateAsync(ReviewUpdateRequest request);
        Task<int> DeleteAsync(int Id);
        Task<double> GetAverageStarAsync(int Id);



    }
}
