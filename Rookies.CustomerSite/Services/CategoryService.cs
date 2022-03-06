using Rookies.ShareClassdLibrary.Constants;
using Rookies.ShareClassdLibrary.Dto;
using Rookies.ShareClassdLibrary.Dto.Category;
using Rookies.ShareClassdLibrary.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rookies.CustomerSite.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpClientFactory _clientFactory;
        public CategoryService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IList<CategoryDto>> GetCategoryAsync()
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var getProductEndpoint = EndpointConstants.GET_CATEGORIES;

            var response = await client.GetAsync(getProductEndpoint);
            response.EnsureSuccessStatusCode();
            var pagedCategories = await response.Content.ReadAsAsync<IList<CategoryDto>>();
            return pagedCategories;
        }
    }
}
