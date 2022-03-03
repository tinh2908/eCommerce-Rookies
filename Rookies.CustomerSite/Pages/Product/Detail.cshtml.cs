using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Rookies.CustomerSite.ViewModel.Product;
using Rookies.ShareClassdLibrary.Constants;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.ShareClassdLibrary.Enum;

namespace Rookies.CustomerSite.Pages.Product
{
    public class DetailModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        public DetailModel(
            IProductService productService,
            IConfiguration config,
            IMapper mapper)
        {
            _productService = productService;
            _config = config;
            _mapper = mapper;
        }

        [BindProperty]
        public ProductVM Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productdto = await _productService.GetProductByIdAsync(id.Value);

            if (productdto == null)
            {
                return NotFound();
            }
            Product = _mapper.Map<ProductVM>(productdto);
            return Page();
        }
    }
}
