using BKShop.ApiIntegration.Interfaces;
using BKShop.CustomersSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;

namespace BKShop.CustomersSite.Pages.Accessory
{
    public class CategoryModel : PageModel
    {
        private readonly ILogger<CategoryModel> _logger;
        private ICategoryApi _categoryApi;
        private IBrandApi _brandApi;
        private IProductApi _productApi;
        public HomeViewModel _homeViewModel;


        public CategoryModel(ILogger<CategoryModel> logger)
        {
            _logger = logger;
            _categoryApi = RestService.For<ICategoryApi>("https://localhost:7297");
            _brandApi = RestService.For<IBrandApi>("https://localhost:7297");
            _productApi = RestService.For<IProductApi>("https://localhost:7297");
            _homeViewModel = new HomeViewModel();

        }
        public async Task<IActionResult> OnGetAsync(int Id)
        {
            var catgories = _categoryApi.GetAllAsync().GetAwaiter().GetResult();
            var accessories = _categoryApi.GetAccessoryAsync().GetAwaiter().GetResult();
            var brands = _brandApi.GetAllAsync().GetAwaiter().GetResult();
            _homeViewModel.Categories = catgories;
            _homeViewModel.Acessories = accessories;
            _homeViewModel.Brands = brands;

            var products = _productApi.GetByCategoryAsync(Id).GetAwaiter().GetResult();
            _homeViewModel.Products = products;
            var category = _categoryApi.GetByIdAsync(Id).GetAwaiter().GetResult();
            _homeViewModel.Category = category;

            return Page();
        }
    }

}
