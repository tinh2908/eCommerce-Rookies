using AutoMapper;
using Rookies.CustomerSite.ViewModel.Rating;
using Rookies.ShareClassdLibrary.Dto.Rating;

namespace Rookie.CustomerSite.Mapping
{
    public class RatingAutoMapperProfile : Profile
    {
        public RatingAutoMapperProfile()
        {
            CreateMap<RatingDto, RatingVM>().ReverseMap();
        }
    }
}
