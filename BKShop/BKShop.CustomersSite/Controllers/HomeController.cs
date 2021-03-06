using BKShop.ApiIntegration.Interfaces;
using BKShop.CustomersSite.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Diagnostics;

namespace BKShop.CustomersSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICategoryApi _categoryApi;
        private IBrandApi _brandApi;
        private IProductApi _productApi;
        private HomeViewModel _homeViewModel;

        public HomeController(ILogger<HomeController> logger)
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
            var products = _productApi.GetAllAsync().GetAwaiter().GetResult();
            var productsTop5 = _productApi.GetTop5Async().GetAwaiter().GetResult();
            _homeViewModel.Categories = catgories;
            _homeViewModel.Acessories = accessories;
            _homeViewModel.Brands = brands;
            _homeViewModel.Products = products;
            _homeViewModel.ProductTop5 = productsTop5;

            return View(_homeViewModel);
        }

        public async Task<IActionResult> Detail(int Id, string Color)
        {
            var catgories = _categoryApi.GetAllAsync().GetAwaiter().GetResult();
            var accessories = _categoryApi.GetAccessoryAsync().GetAwaiter().GetResult();
            var brands = _brandApi.GetAllAsync().GetAwaiter().GetResult();
            var productsTop5 = _productApi.GetTop5Async().GetAwaiter().GetResult();
            _homeViewModel.Categories = catgories;
            _homeViewModel.Acessories = accessories;
            _homeViewModel.Brands = brands;
            _homeViewModel.ProductTop5 = productsTop5;

            var product = _productApi.GetByIdAsync(Id).GetAwaiter().GetResult();
            _homeViewModel.Product = product;
            var brand = _brandApi.GetByIdAsync(product.BrandId).GetAwaiter().GetResult();
            _homeViewModel.Brand = brand;

            _homeViewModel.color_url = Color;
            _homeViewModel.id_url = Id;

            var group = product.Group;
            var productByColorByGroup = _productApi.GetByColorAndGroupAsync(Color, group).GetAwaiter().GetResult();
            var color = _productApi.GetColorByGroupAsync(group).GetAwaiter().GetResult();

            _homeViewModel.ProductByColorAndGroup = productByColorByGroup;
            _homeViewModel.Colors = color;



            return View(_homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}