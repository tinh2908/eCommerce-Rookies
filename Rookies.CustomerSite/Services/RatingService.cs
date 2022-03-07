using Newtonsoft.Json;
using Rookies.CustomerSite.ViewModel.Rating;
using Rookies.ShareClassdLibrary.Constants;
using Rookies.ShareClassdLibrary.Dto;
using Rookies.ShareClassdLibrary.Dto.Category;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.ShareClassdLibrary.Dto.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rookies.CustomerSite.Services
{
    public class RatingService : IRatingService
    {
        private readonly IHttpClientFactory _clientFactory;
        public RatingService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<RatingDto> GetRatingAsync()
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var getRatingEndpoint = EndpointConstants.GET_RATING;

            var response = await client.GetAsync(getRatingEndpoint);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsAsync<RatingDto>();
            return responseString;
        }
         public async Task<RatingDto> PostRatingAsync(RatingVM ratingVM)
        {
            var newrate = new RatingDto
            {
                RatingScore = ratingVM.RatingScore,
                ProductId = ratingVM.ProductId
            };
            var json = JsonConvert.SerializeObject(newrate);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var getRatingEndpoint = EndpointConstants.GET_RATING;

            var response = await client.PostAsync(getRatingEndpoint, stringContent);
            response.EnsureSuccessStatusCode();
            var ratings = await response.Content.ReadAsAsync<RatingDto>();
            return ratings;
        }
    }
}
