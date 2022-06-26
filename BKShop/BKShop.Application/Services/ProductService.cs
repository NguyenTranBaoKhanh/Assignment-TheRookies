using BKShop.Application.Catalog.Products.Dtos;
using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.ViewModels.Common;
using BKShop.ViewModels.Requests.Product;
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
        public Task<int> AddComment(int idproduct, string comment, Guid user)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(ProductCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int ProductId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductViewModel>> GetAllPagingAsync(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetBackToSchool()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetBestChoice()
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> GetByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetLatestProduct()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
