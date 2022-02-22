using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Rookie.CustomerSite.ViewModel;
using Rookies.ShareClassdLibrary;
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
        [BindProperty]
        public PagedResponseVM<ProductVM> Products { get; set; }

        public async Task OnGetAsync(string sortOrder,
           string currentFilter, string searchString, int? pageIndex)
        {      
            var productCriteriaDto = new ProductCriteriaDto()
            {
                Search = searchString,
                SortOrder = SortOrderEnum.Accsending,
                Page = pageIndex ?? 1,
                Limit = int.Parse(_config[ConfigurationConstants.PAGING_LIMIT])
            };
            var pageProducts = await _productService.GetProductAsync(productCriteriaDto);
            Products = _mapper.Map<PagedResponseVM<ProductVM>>(pageProducts);
        }
    }
    public class Binding
    {
        public string sortOrder { get; set; }
        public string searchString { get; set; }
        public string currentFilter { get; set; }
        public int? pageIndex { get; set; }
    }
}
