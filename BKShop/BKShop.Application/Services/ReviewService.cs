using AutoMapper;
using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.ViewModels.Requests.Review;
using BKShop.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly BKShopDbContext _context;
        private readonly IMapper _mapper;

        public ReviewService(BKShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(ReviewCreateRequest request)
        {
            if(request == null)
            {
                return 0;
            }
            if(request.Star == 0)
            {
                request.Star = 5;
            }
            var review = new Review()
            {
                UserId = request.UserId,
                ProductId = request.ProductId,
                Comment = request.Comment,
                Star = request.Star,
                DateCreated = DateTime.Now,
            };
            await _context.Reviews.AddAsync(review);
            var result = await _context.SaveChangesAsync();
            if(result == 0)
            {
                return 0;
            }
            return review.Id;
        }

        public Task<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReviewViewModel>> GetAllAsync()
        {
            return await _context.Reviews.Select(review => _mapper.Map<ReviewViewModel>(review)).ToListAsync();

        }

        public async Task<double> GetAverageStarAsync(int Id)
        {
            var review = await _context.Reviews.Where(review => review.ProductId == Id).ToListAsync();
            if (review.Count() == 0)
            {
                return 0;
            }
            var avg = review.Average(review => review.Star);
            return avg;
        }

        public async Task<ReviewViewModel> GetByIdAsync(int Id)
        {
            var review = await _context.Reviews.Where(rv => rv.Id==Id).Include(rv => rv.User).SingleOrDefaultAsync();
            if(review == null)
            {
                return null;
            }
            return new ReviewViewModel()
            {
                Id = review.Id,
                UserId = review.UserId,
                UserName = review.User.UserName,
                Name = review.User.Name,
                ProductId = review.ProductId,
                Comment = review.Comment,
                Star = review.Star,
                DateCreated = review.DateCreated,
                DateModified = review.DateModified,
                DateDeleted = review.DateDeleted
            };

        }

        public async Task<List<ReviewViewModel>> GetByProductIdAsync(int productId)
        {
            return await _context.Reviews.Where(review => review.ProductId == productId).Select(review => new ReviewViewModel()
            {
                Id = review.Id,
                UserId = review.UserId,
                UserName = review.User.UserName,
                Name = review.User.Name,
                ProductId = review.ProductId,
                Comment = review.Comment,
                Star = review.Star,
                DateCreated = review.DateCreated,
                DateDeleted = review.DateDeleted,
                DateModified = review.DateModified
            }).ToListAsync();
        }

        public async Task<List<ReviewViewModel>> GetByUserIdAsync(Guid userId)
        {
            return await _context.Reviews.Where(review => review.UserId == userId).Select(review => new ReviewViewModel()
            {
                Id = review.Id,
                UserId = review.UserId,
                UserName = review.User.UserName,
                Name = review.User.Name,
                ProductId = review.ProductId,
                Comment = review.Comment,
                Star = review.Star,
                DateCreated = review.DateCreated,
                DateDeleted = review.DateDeleted,
                DateModified = review.DateModified
            }).ToListAsync();
        }

        public Task<int> UpdateAsync(ReviewUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
