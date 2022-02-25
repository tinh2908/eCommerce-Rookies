using AutoMapper;
using Rookies.CustomerSite.ViewModel.Category;
using Rookies.ShareClassdLibrary.Dto.Category;

namespace Rookie.CustomerSite.Mapping
{
    public class CategoryAutoMapperProfile : Profile
    {
        public CategoryAutoMapperProfile()
        {
            CreateMap<CategoryDto, CategoryVM>().ReverseMap();
        }
    }
}
