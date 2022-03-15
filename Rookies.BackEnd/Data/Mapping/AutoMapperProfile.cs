using AutoMapper;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.BackEnd.Helpers;
using Rookies.ShareClassdLibrary.Dto.Category;
using Rookies.ShareClassdLibrary.Dto.ProductbyCate;
using Rookies.ShareClassdLibrary.Dto.Rating;

namespace RookieShop.Backend.Data.Mapping
{
    public class AutoMapperProfile : Profile  
    {
        public AutoMapperProfile()  
        {
            CreateMap<Product, ProductDto>()
                 .ForMember(src => src.ImagePath,
                           opts => opts
                                    .MapFrom(src => ImageHelper
                                                        .GetFileUrl(src.ImageName)
                                            ));
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductbyCateDto>()
                 .ForMember(src => src.ImagePath,
                           opts => opts
                                    .MapFrom(src => ImageHelper
                                                        .GetFileUrl(src.ImageName)
                                            ));
            CreateMap<Rating, RatingDto>();
        }
    }
}