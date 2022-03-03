using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Rookies.ShareClassdLibrary.Dto.Rating;

public interface IRatingService
{
    Task<RatingDto> GetRatingAsync();

}