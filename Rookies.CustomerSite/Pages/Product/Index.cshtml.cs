using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Rookie.CustomerSite.ViewModel;
using Rookies.CustomerSite.ViewModel.Product;
using Rookies.ShareClassdLibrary.Constants;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.ShareClassdLibrary.Enum;

namespace Rookies.CustomerSite.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        public IndexModel(
            IProductService productService,
            IConfiguration config,
            IMapper mapper)
        {
            _productService = productService;
            _config = config;
            _mapper = mapper;          
        }
        //[BindProperty(SupportsGet = true)]
        //public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public PagedResponseVM<ProductVM> Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; }

        public async Task OnGetAsync()
        {
            var productCriteriaDto = new ProductCriteriaDto()
            {
                Search = Products.Search,
                SortOrder = Products.SortOrder,
                Page = PageIndex,
                Limit = int.Parse(_config[ConfigurationConstants.PAGING_LIMIT])
            };
            var pageProducts = await _productService.GetProductAsync(productCriteriaDto);
            Products = _mapper.Map<PagedResponseVM<ProductVM>>(pageProducts);
        }
    }
    
}
