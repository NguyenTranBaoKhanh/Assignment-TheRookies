using BKShop.ViewModels.Requests.Review;
using BKShop.ViewModels.ViewModels;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.ApiIntegration.Interfaces
{
    public interface IReviewApi
    {
        [Get("/api/Review/product/{Id}")]
        Task<List<ReviewViewModel>> GetByProductIdAsync(int Id);

        [Post("/api/Review")]
        Task<ReviewViewModel> CreateAsync(ReviewCreateRequest request);

        [Get("/api/Review/AverageStar/{productId}")]
        Task<double> GetAverageStarAsync(int productId);
    }
}
