using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Rookies.CustomerSite.ViewModel.Product;
using Rookies.CustomerSite.ViewModel.Rating;
using Rookies.ShareClassdLibrary.Constants;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.ShareClassdLibrary.Dto.Rating;
using Rookies.ShareClassdLibrary.Enum;

namespace Rookies.CustomerSite.Pages.Product
{
    public class DetailModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IRatingService _ratingService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        public DetailModel(
            IProductService productService,
            IRatingService ratingService,
            IConfiguration config,
            IMapper mapper)
        {
            _productService = productService;
            _ratingService = ratingService;
            _config = config;
            _mapper = mapper;
        }

        [BindProperty(SupportsGet = true)]
        public ProductVM Product { get; set; }
        [BindProperty]
        public RatingVM Rating { get; set; }
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

        public async Task OnPostAsync(int? id)
        {
            var ratingdto = await _ratingService.PostRatingAsync(Rating);
            Rating = _mapper.Map<RatingVM>(ratingdto);
            await OnGetAsync(id);
        }
    }
}
