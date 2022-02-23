using AutoMapper;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.BackEnd.Helpers;

namespace RookieShop.Backend.Data.Mapping
{
    public class AutoMapperProfile : Profile  
    {
        public AutoMapperProfile()  
        {
            CreateMap<Product, ProductDto>();


        }
    }
}