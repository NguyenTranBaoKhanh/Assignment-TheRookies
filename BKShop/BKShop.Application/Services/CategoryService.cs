using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.Utilities.Exceptions;
using BKShop.ViewModels.Requests.Category;
using BKShop.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly BKShopDbContext _context;
        private readonly IProductService _productService;

        public CategoryService(BKShopDbContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        public async Task<int> CreateAsync(CategoryCreateRequest request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                return 0;
            }
            var category = new Category()
            {
                Name = request.Name,
            };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category.Id;

        }

        //public Task<int> DeleteAsync(int categoryId)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<int> DeleteAsync(int categoryId)
        {
            var category = await _context.Categories.Where(x => x.Id == categoryId).FirstOrDefaultAsync();
            if (category == null)
            {
                throw new BKShopException($"Cannot find category with Id = {categoryId}");
            }
            //var productList = await _context.Products.Where(x => x.CategoryId == categoryId).ToListAsync();
            //foreach (var product in productList)
            //{
            //    await _productService.DeleteAsync(product.Id);
            //}
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<CategoryViewModel>> GetAllAsync()
        {
            return await _context.Categories.Select(category => new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
            }).ToListAsync();
        }

        public async Task<CategoryViewModel> GetByIdAsync(int categoryId)
        {
            var category = await _context.Categories.Where(x=>x.Id == categoryId).FirstOrDefaultAsync();
            if(category == null)
            {
                throw new BKShopException($"Cannot find category with Id = {categoryId}");
            }
            return new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
            };
        }

        public async Task<int> UpdateAsync(CategoryUpdateRequest request)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            if(category == null)
            {
                throw new BKShopException($"Cannot find category with Id = {request.Id}");
            }
            category.Name = request.Name;
            return await _context.SaveChangesAsync();
        }
    }
}
