using BKShop.ViewModels.ViewModels;

namespace BKShop.CustomersSite.Models
{
    public class HomeViewModel
    {
        public List<CategoryViewModel> Categories;
        public List<CategoryViewModel> Acessories;
        public List<BrandViewModel> Brands;
        public List<ProductViewModel> Products;
        public List<ProductViewModel> ProductTop5;
        public ProductViewModel Product;
    }
}
