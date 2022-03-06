﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rookies.BackEnd.Data;
using Rookies.ShareClassdLibrary.Dto.Category;
using Rookies.ShareClassdLibrary.Dto.ProductbyCate;
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
                               .AsQueryable();

            if (category == null)
            {
                return NotFound();
            }
            var categoryDtos = _mapper.Map<IEnumerable<CategoryDto>>(category);
            return Ok(categoryDtos);
        }

        [HttpGet("{cateid}")]
        [AllowAnonymous]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]

        public ActionResult<ProductbyCateDto> GetProductByCategory(int cateid)
        {
            var product = _context
                                .Product
                                .Where(x => x.CategoryId == cateid)
                                //.Include(p => p.Categories)
                                .AsQueryable();

            if (product == null)
            {
                return NotFound();
            }

            var categoryDtos = _mapper.Map<IEnumerable<ProductbyCateDto>>(product);

            return Ok(categoryDtos);
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

            _context.Category.Update(category);
            await _context.SaveChangesAsync();

            return Ok(true);
        }
    }

}
