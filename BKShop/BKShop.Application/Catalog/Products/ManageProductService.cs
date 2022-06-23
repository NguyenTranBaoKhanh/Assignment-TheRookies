using BKShop.Application.Catalog.Products.Dtos;
using BKShop.Application.Catalog.Products.Dtos.Manage;
using BKShop.Application.Dtos;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly BKShopDbContext _context;
        public ManageProductService(BKShopDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                Name = request.Name,
                Color = request.Color,
                Capacity = request.Capacity,
                Stock = request.Stock,
                Description = request.Description,
                Image = request.Image,
                CategoryId = request.CategoryId,
                BrandId = request.BrandId,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
            
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new BKShopException($"Can not find a product: {productId}");
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        //public async Task<PageResult<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            //var query = _context.Products.Where(p=>p.Name)
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                var query = _context.Products.Where(p => p.Name.Contains(request.Keyword));
            }
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStock(int productId, int newQuantity)
        {
            throw new NotImplementedException();
        }
        //aaaaaaaaaaaaaaaaaaaaaaaa
    }
}
