using BKShop.ApiIntegration.Interfaces;
using BKShop.CustomersSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;

namespace BKShop.CustomersSite.Pages.Smartphone
{
    public class BrandModel : PageModel
    {
        private readonly ILogger<BrandModel> _logger;
        private ICategoryApi _categoryApi;
        private IBrandApi _brandApi;
        private IProductApi _productApi;
        public HomeViewModel _homeViewModel;


        public BrandModel(ILogger<BrandModel> logger)
        {
            _logger = logger;
            _categoryApi = RestService.For<ICategoryApi>("https://localhost:7297");
            _brandApi = RestService.For<IBrandApi>("https://localhost:7297");
            _productApi = RestService.For<IProductApi>("https://localhost:7297");
            _homeViewModel = new HomeViewModel();

        }
        //public void OnGet()
        //{
        //}
        public async Task<IActionResult> OnGetAsync(int Id)
        {
            var catgories = _categoryApi.GetAllAsync().GetAwaiter().GetResult();
            var accessories = _categoryApi.GetAccessoryAsync().GetAwaiter().GetResult();
            var brands = _brandApi.GetAllAsync().GetAwaiter().GetResult();
            _homeViewModel.Categories = catgories;
            _homeViewModel.Acessories = accessories;
            _homeViewModel.Brands = brands;

            var brand = _brandApi.GetByIdAsync(Id).GetAwaiter().GetResult();
            _homeViewModel.Brand = brand;
            var products = _productApi.GetByCategoryByBrandAsync(1, Id).GetAwaiter().GetResult();
            _homeViewModel.Products = products;


            return Page();
        }
    }
}
