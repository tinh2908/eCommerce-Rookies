using AutoMapper;
using Rookie.CustomerSite.ViewModel;
using Rookie.CustomerSite.ViewModel.Product;
using Rookies.ShareClassdLibrary.Dto;
using Rookies.ShareClassdLibrary.Dto.Product;


namespace Rookie.CustomerSite.Mapping
{
    public class ProductAutoMapperProfile : Profile
    {
        public ProductAutoMapperProfile()  
        {  
            CreateMap<ProductDto, ProductVM>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();  
            CreateMap<PagedResponseDto<ProductDto>, PagedResponseVM<ProductDto>>().ReverseMap();
        }  
    }
}
