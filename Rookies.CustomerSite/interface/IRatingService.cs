using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Rookies.CustomerSite.ViewModel.Rating;
using Rookies.ShareClassdLibrary.Dto.Rating;

public interface IRatingService
{
    Task<RatingDto> GetRatingAsync();
    Task<RatingDto> PostRatingAsync(RatingVM ratingVM);
}