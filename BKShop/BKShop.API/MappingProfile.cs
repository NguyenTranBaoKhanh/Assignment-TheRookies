using AutoMapper;
using BKShop.Data.Entities;
using BKShop.ViewModels.ViewModels;

namespace BKShop.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
