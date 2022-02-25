using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Rookie.CustomerSite.ViewModel.Product;

namespace Rookies.CustomerSite.Pages.Category
{
    public class ProductByCateModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductByCateModel(
            IProductService productService,
            IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [BindProperty(SupportsGet = true)]
        public IList<ProductByCateVM> Product { get; set; }
        public async Task OnGetAsync(int cateid)
        {
            var pageCategories = await _productService.GetProductByCateAsync(cateid);
            Product = _mapper.Map<IList<ProductByCateVM>>(pageCategories);
        }
    }
}
