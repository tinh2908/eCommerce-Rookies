using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rookies.BackEnd.Data;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Dto.Category;
using Rookies.ShareClassdLibrary.Dto.ProductbyCate;
using RookieShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoryController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        [AllowAnonymous]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public ActionResult<CategoryDto> GetCategories()
        {
            var category = _context
                               .Category
                               .Where(x => !x.IsDeleted)
                               .AsQueryable();

            if (category == null)
            {
                return NotFound();
            }
            var categoryDtos = _mapper.Map<IEnumerable<CategoryDto>>(category);
            return Ok(categoryDtos);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public ActionResult<CategoryDto> GetCategory(int id)
        {
            var rating = _context
                                .Category
                                .Where(x => !x.IsDeleted && x.Id == id)
                                .FirstOrDefault();

            if (rating == null)
            {
                return NotFound();
            }

            var categoryDtos = _mapper.Map<CategoryDto>(rating);

            return Ok(categoryDtos);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryDto>> PostCategory([FromForm] CategoryCreateRequest categoryCreateRequeset)
        {
            var category = new Category
            {
                Name = categoryCreateRequeset.Name,
            };
            _context.Category.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.Id },
                new CategoryDto
                {
                    Name = category.Name
                });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }
            _context.Category.Update(category);
            await _context.SaveChangesAsync();

            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsDeleted = true;
            _context.Category.Update(category);
            await _context.SaveChangesAsync();

            return Ok(true);
        }
    }

}
