using BKShop.ApiIntegration.Interfaces;
using BKShop.CustomersSite.Models;
using BKShop.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Refit;

namespace BKShop.Customers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ICategoryApi _categoryApi;
        private IBrandApi _brandApi;
        private IProductApi _productApi;
        public HomeViewModel _homeViewModel;

        //public List<CategoryViewModel> Categories = new List<CategoryViewModel>();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _categoryApi = RestService.For<ICategoryApi>("https://localhost:7297");
            _brandApi = RestService.For<IBrandApi>("https://localhost:7297");
            _productApi = RestService.For<IProductApi>("https://localhost:7297");
            _homeViewModel = new HomeViewModel();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var catgories = _categoryApi.GetAllAsync().GetAwaiter().GetResult();
            var accessories = _categoryApi.GetAccessoryAsync().GetAwaiter().GetResult();
            var brands = _brandApi.GetAllAsync().GetAwaiter().GetResult();
            var products = _productApi.GetAllAsync().GetAwaiter().GetResult();
            var productsTop5 = _productApi.GetTop5Async().GetAwaiter().GetResult();
            _homeViewModel.Categories = catgories;
            _homeViewModel.Acessories = accessories;
            _homeViewModel.Brands = brands;
            _homeViewModel.Products = products;
            _homeViewModel.ProductTop5 = productsTop5;

            return Page();
        }

        //public async Task<IActionResult> Brand(int Id)
        //{
        //    var catgories = _categoryApi.GetAllAsync().GetAwaiter().GetResult();
        //    var accessories = _categoryApi.GetAccessoryAsync().GetAwaiter().GetResult();
        //    var brands = _brandApi.GetAllAsync().GetAwaiter().GetResult();
        //    _homeViewModel.Categories = catgories;
        //    _homeViewModel.Acessories = accessories;
        //    _homeViewModel.Brands = brands;

        //    var brand = _brandApi.GetByIdAsync(Id).GetAwaiter().GetResult();
        //    _homeViewModel.Brand = brand;
        //    var products = _productApi.GetByCategoryByBrandAsync(1, Id).GetAwaiter().GetResult();
        //    _homeViewModel.Products = products;


        //    return Page();
        //}
    }
}