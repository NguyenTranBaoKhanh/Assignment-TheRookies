using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.Utilities.Exceptions;
using BKShop.ViewModels.Requests.Brand;
using BKShop.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly BKShopDbContext _context;
        public BrandService (BKShopDbContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(BrandCreateRequest request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                return 0;
            }
            var brand = new Brand()
            {
                Name = request.Name,
            };
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
            return brand.Id;
        }

        public async Task<int> DeleteAsync(int brandId)
        {
            var brand = await _context.Brands.Where(x => x.Id == brandId).FirstOrDefaultAsync();
            if(brand == null)
            {
                throw new BKShopException($"Cannot find brand with Id = {brandId}");
            }
            _context.Brands.Remove(brand);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<BrandViewModel>> GetAllAsync()
        {
            return await _context.Brands.Select(brand => new BrandViewModel()
            {
                Id = brand.Id,
                Name = brand.Name,
            }).ToListAsync();
        }

        public async Task<BrandViewModel> GetByIdAsync(int brandId)
        {
            var brand = await _context.Brands.Where(x => x.Id == brandId).FirstOrDefaultAsync();
            if (brand == null)
            {
                throw new BKShopException($"Cannot find brand with Id = {brandId}");
            }
            return new BrandViewModel()
            {
                Id = brand.Id,
                Name = brand.Name,
            };
        }

        public async Task<int> UpdateAsync(BrandUpdateRequest request)
        {
            var brand = await _context.Brands.FindAsync(request.Id);
            if (brand == null)
            {
                throw new BKShopException($"Cannot find brand with Id = {request.Id}");
            }
            brand.Name = request.Name;
            return await _context.SaveChangesAsync();
        }
    }
}
