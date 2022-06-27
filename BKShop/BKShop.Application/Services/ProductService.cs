using AutoMapper;
using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.Utilities.Exceptions;
using BKShop.ViewModels.Common;
using BKShop.ViewModels.Requests.Product;
using BKShop.ViewModels.ViewModels;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly BKShopDbContext _context;
        private readonly IMapper _mapper;
        public ProductService(BKShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> AddComment(int productId, string comment, Guid user)
        {
            var review = new Review()
            {
                UserId = user,
                ProductId = productId,
                Comment = comment,
                DateCreated = DateTime.Now,
                Star = 5,

            };
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            return review.Id;
        }

        public async Task<int> CreateAsync(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.Name,
                CategoryId = request.CategoryId,
                BrandId = request.BrandId,
                Color = request.Color,
                Capacity = request.Capacity,
                Description = request.Description,
                Price = request.Price,
                Stock = request.Stock,
                Image = request.Image

            };
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<int> DeleteAsync(int productId)
        {
            var product = await _context.Products.Where(x => x.Id == productId).FirstOrDefaultAsync();
            if (product == null)
            {
                throw new BKShopException($"Cannot find product with Id = {productId}");
            }
         
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ProductViewModel>> GetAllAsync()
        {
            //return await _context.Products.Select(product => new ProductViewModel()
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    BrandId = product.BrandId,
            //    Description = product.Description,
            //    Color = product.Color,
            //    CategoryId = product.CategoryId,
            //    Stock = product.Stock,
            //    Capacity = product.Capacity
            //}).ToListAsync();

            return await _context.Products.Select(product => _mapper.Map<ProductViewModel>(product)).ToListAsync();

        }

        public Task<PagedResult<ProductViewModel>> GetAllPagingAsync(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductViewModel> GetByIdAsync(int productId)
        {
            var product = await _context.Products.Where(x => x.Id == productId).FirstOrDefaultAsync();
            if (product == null)
            {
                throw new BKShopException($"Cannot find product with Id = {productId}");
            }

            return _mapper.Map<ProductViewModel>(product);
            //var productVm = new ProductViewModel()
            //{
            //    CategoryId = product.CategoryId,
            //    Stock = product.Stock,
            //    Id = product.Id,
            //    Name = product.Name,
            //    Price = product.Price,
            //    Description = product.Description,
            //};
            //return productVm;
        }

        public Task<List<ProductViewModel>> GetLatestProduct()
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if (product == null)
            {
                throw new BKShopException($"Cannot find product with Id = {request.Id}");
            }
            product.Name = request.Name;
            product.BrandId = request.BrandId;
            product.Description = request.Description;
            product.Color = request.Color;
            product.CategoryId = request.CategoryId;
            product.Stock = request.Stock;
            product.Capacity = request.Capacity;

            return await _context.SaveChangesAsync();
        }

        


    }
}
