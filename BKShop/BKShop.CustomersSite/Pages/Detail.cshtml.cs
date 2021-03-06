using BKShop.ApiIntegration.Interfaces;
using BKShop.CustomersSite.Models;
using BKShop.ViewModels.Requests.Product;
using BKShop.ViewModels.Requests.Review;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Refit;
using System.Net;

namespace BKShop.CustomersSite.Pages
{
    public class DetailModel : PageModel
    {
        private readonly ILogger<DetailModel> _logger;
        private ICategoryApi _categoryApi;
        private IBrandApi _brandApi;
        private IProductApi _productApi;
        private IReviewApi _reviewApi;
        public HomeViewModel _homeViewModel;

        //public List<CategoryViewModel> Categories = new List<CategoryViewModel>();
        public DetailModel(ILogger<DetailModel> logger)
        {
            _logger = logger;
            _categoryApi = RestService.For<ICategoryApi>("https://localhost:7297");
            _brandApi = RestService.For<IBrandApi>("https://localhost:7297");
            _productApi = RestService.For<IProductApi>("https://localhost:7297");
            _reviewApi = RestService.For<IReviewApi>("https://localhost:7297");
            _homeViewModel = new HomeViewModel();
        }

        public async Task<IActionResult> OnGetAsync(int Id, string Color)
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

            var reviews = _reviewApi.GetByProductIdAsync(Id).GetAwaiter().GetResult();
            _homeViewModel.Reviews = reviews;

            var avgStar = _reviewApi.GetAverageStarAsync(Id).GetAwaiter().GetResult();
            _homeViewModel.AvgStar = avgStar;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int Id, ReviewCreateRequest Rrequest, ProductStarUpdateRequest Urequest)
        {

            Rrequest.UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928");
            Rrequest.ProductId = Id;
            Urequest.productId = Id;
            //Rrequest.Star = Request.Form["star"];
            _reviewApi.CreateAsync(Rrequest).GetAwaiter().GetResult();
            Urequest.Stars = _reviewApi.GetAverageStarAsync(Id).GetAwaiter().GetResult();
            _productApi.UpdateStarAsync(Urequest).GetAwaiter().GetResult();

            var product = _productApi.GetByIdAsync(Id).GetAwaiter().GetResult();
            string url = "detail?Id=" + Id + "&Color=" + product.Color;

            var encoded = Flurl.Url.EncodeIllegalCharacters(url);
            return base.Redirect(encoded);
            //return Redirect(url);


        }
    }
}