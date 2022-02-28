using AutoMapper;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.BackEnd.Helpers;
using Rookies.ShareClassdLibrary.Dto.Category;
using Rookies.ShareClassdLibrary.Dto.ProductbyCate;
using Rookies.ShareClassdLibrary.Dto.Raing;

namespace RookieShop.Backend.Data.Mapping
{
    public class AutoMapperProfile : Profile  
    {
        public AutoMapperProfile()  
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductbyCateDto>();
            CreateMap<Rating, RatingDto>();
        }
    }
}