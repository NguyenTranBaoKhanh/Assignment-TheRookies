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
        public BrandViewModel Brand;
        public String color_url;
        public int id_url;
        public List<ProductViewModel> ProductByColorAndGroup;
        public List<ArrayViewModel> Colors;
        public List<ReviewViewModel> Reviews;
        public double AvgStar;
    }
}