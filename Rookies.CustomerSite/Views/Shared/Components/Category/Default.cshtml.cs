using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rookies.CustomerSite.ViewModel.Category;

namespace Rookies.CustomerSite.Views.Shared.Components.Category
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryViewComponent(
            ICategoryService categoryService,
            IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [BindProperty(SupportsGet = true)]
        public IList<CategoryVM> Categories { get; set; }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pageCategories = await _categoryService.GetCategoryAsync();
            Categories = _mapper.Map<IList<CategoryVM>>(pageCategories);
            return View(Categories);
        }
    }
}