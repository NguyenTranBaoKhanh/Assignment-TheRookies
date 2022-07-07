using BKShop.ApiIntegration.Interfaces;
using BKShop.CustomersSite.Models;
using BKShop.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BKShop.CustomersSite.Pages.Shared.Components.BestSeller
{
    public class BestSeller : ViewComponent
    {
        private IProductApi _productApi;
        public HomeViewModel _homeViewModel;

        public BestSeller()
        {
            _productApi = RestService.For<IProductApi>("https://localhost:7297");
            _homeViewModel = new HomeViewModel();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var productsTop5 = _productApi.GetTop5Async().GetAwaiter().GetResult();
            //_homeViewModel.ProductTop5 = productsTop5;

            return View<List<ProductViewModel>>(productsTop5);
        }
    }
}
