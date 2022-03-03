using AutoMapper;
using Rookie.CustomerSite.ViewModel;
using Rookies.CustomerSite.ViewModel.Product;
using Rookies.ShareClassdLibrary.Dto.ProductbyCate;
using Rookies.ShareClassdLibrary.Dto;
using Rookies.ShareClassdLibrary.Dto.Product;

namespace Rookie.CustomerSite.Mapping
{
    public class ProductAutoMapperProfile : Profile
    {
        public ProductAutoMapperProfile()  
        {
            CreateMap<ProductDto, ProductVM>().ReverseMap();
            CreateMap<ProductbyCateDto, ProductByCateVM>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();
            CreateMap<PagedResponseDto<ProductDto>, PagedResponseVM<ProductVM>>().ReverseMap();
        }  
    }
}
