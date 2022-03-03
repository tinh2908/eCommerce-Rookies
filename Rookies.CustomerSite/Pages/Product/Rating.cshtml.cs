using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rookies.CustomerSite.Pages.Product
{
    public class RatingModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public RatingModel(
            IProductService productService,
            IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public void OnGet()
        {
        }
    }
}
