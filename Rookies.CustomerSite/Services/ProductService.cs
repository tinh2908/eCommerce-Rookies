using Rookies.ShareClassdLibrary.Constants;
using Rookies.ShareClassdLibrary.Dto;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.ShareClassdLibrary.Dto.ProductbyCate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rookies.CustomerSite.Services
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProductService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<PagedResponseDto<ProductDto>> GetProductAsync(ProductCriteriaDto productCriteriaDto)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var getProductEndpoint = string.IsNullOrEmpty(productCriteriaDto.Search) ?
                            EndpointConstants.GET_PRODUCTS :
                            $"{EndpointConstants.GET_PRODUCTS}?Search={productCriteriaDto.Search}";

            var response = await client.GetAsync(getProductEndpoint);
            response.EnsureSuccessStatusCode();
            var pagedProducts = await response.Content.ReadAsAsync<PagedResponseDto<ProductDto>>();
            return pagedProducts;
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync($"{EndpointConstants.GET_PRODUCTS}\\{id}");
            response.EnsureSuccessStatusCode();
            var Product = await response.Content.ReadAsAsync<ProductDto>();
            return Product;
        }

        public async Task<IList<ProductbyCateDto>> GetProductByCateAsync(int cateid)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync($"{EndpointConstants.GET_CATEGORIES}\\{cateid}");
            response.EnsureSuccessStatusCode();
            var pagedCategories = await response.Content.ReadAsAsync<IList<ProductbyCateDto>>();
            return pagedCategories;
        }
    }
}
