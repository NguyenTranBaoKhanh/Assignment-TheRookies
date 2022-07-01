using BKShop.ApiIntegration.Interfaces;
using BKShop.CustomersSite.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BKShop.CustomersSite.Controllers
{
    public class TabletController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private ICategoryApi _categoryApi;
        private IBrandApi _brandApi;
        private IProductApi _productApi;
        private HomeViewModel _homeViewModel;


        public TabletController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _categoryApi = RestService.For<ICategoryApi>("https://localhost:7297");
            _brandApi = RestService.For<IBrandApi>("https://localhost:7297");
            _productApi = RestService.For<IProductApi>("https://localhost:7297");
            _homeViewModel = new HomeViewModel();

        }
        public async Task<IActionResult> Index()
        {
            var catgories = _categoryApi.GetAllAsync().GetAwaiter().GetResult();
            var accessories = _categoryApi.GetAccessoryAsync().GetAwaiter().GetResult();
            var brands = _brandApi.GetAllAsync().GetAwaiter().GetResult();
            _homeViewModel.Categories = catgories;
            _homeViewModel.Acessories = accessories;
            _homeViewModel.Brands = brands;

            var product = _productApi.GetByCategoryAsync(4).GetAwaiter().GetResult();
            _homeViewModel.Products = product;

            return View(_homeViewModel);
        }

        public async Task<IActionResult> Brand(int Id)
        {
            var catgories = _categoryApi.GetAllAsync().GetAwaiter().GetResult();
            var accessories = _categoryApi.GetAccessoryAsync().GetAwaiter().GetResult();
            var brands = _brandApi.GetAllAsync().GetAwaiter().GetResult();
            _homeViewModel.Categories = catgories;
            _homeViewModel.Acessories = accessories;
            _homeViewModel.Brands = brands;

            var brand = _brandApi.GetByIdAsync(Id).GetAwaiter().GetResult();
            _homeViewModel.Brand = brand;
            var products = _productApi.GetByCategoryByBrandAsync(4, Id).GetAwaiter().GetResult();
            _homeViewModel.Products = products;


            return View(_homeViewModel);
        }
    }
}
