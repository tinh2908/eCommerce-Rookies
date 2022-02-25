using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rookies.CustomerSite.ViewModel.Category;

namespace Rookies.CustomerSite.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public IndexModel(
            ICategoryService categoryService,
            IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [BindProperty(SupportsGet = true)]
        public IList<CategoryVM> Categories { get; set; }
        public async Task OnGetAsync()
        {
            var pageCategories = await _categoryService.GetCategoryAsync();
            Categories = _mapper.Map<IList<CategoryVM>>(pageCategories);
        }
    }
}
