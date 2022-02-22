using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rookies.BackEnd.Data;
using Rookies.BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rookies.ShareClassdLibrary;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.ShareClassdLibrary.Enum;
using Rookies.ShareClassdLibrary.Dto;
using AutoMapper;
using System.Threading;
using Rookies.BackEnd.Extension;

namespace Rookies.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        //[AllowAnonymous]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult<PagedResponseDto<ProductDto>>> GetProducts(
            [FromQuery] ProductCriteriaDto productCriteriaDto,
            CancellationToken cancellationToken)
        {
            var productQuery = _context
                                .Product                         
                                .AsQueryable();
            productQuery = ProductFilter(productQuery, productCriteriaDto);

            var pagedProduct = await productQuery
                                .AsNoTracking()
                                .PaginateAsync(productCriteriaDto, cancellationToken);

            var productDto = _mapper.Map<IEnumerable<ProductDto>>(pagedProduct.Items);
            return new PagedResponseDto<ProductDto>
            {
                CurrentPage = pagedProduct.CurrentPage,
                TotalPages = pagedProduct.TotalPages,
                TotalItems = pagedProduct.TotalItems,
                Search = productCriteriaDto.Search,
                SortColumn = productCriteriaDto.SortColumn,
                SortOrder = productCriteriaDto.SortOrder,
                Limit = productCriteriaDto.Limit,
                Items = productDto
            };
        }

        [HttpGet("{id}")]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult<ProductVM>> GetProduct(int id)
        {
            var product = await _context
                                .Product
                                .Where(x => x.Id == id)
                                .FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            var productVM = new ProductVM
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CreatedDate = product.CreatedDate,
                CategoryId = product.CategoryId
            };

            return productVM;
        }

        private IQueryable<Product> ProductFilter(
           IQueryable<Product> productQuery,
           ProductCriteriaDto productCriteriaDto)
        {
            if (!String.IsNullOrEmpty(productCriteriaDto.Search))
            {
                productQuery = productQuery.Where(b =>
                    b.Name.Contains(productCriteriaDto.Search));
            }

            if (productCriteriaDto.CategoryId != null &&
                productCriteriaDto.CategoryId.Count() > 0 &&
               !productCriteriaDto.CategoryId.Any(x => x == (int)ProductCategoryEnum.All))
            {
                productQuery = productQuery.Where(x =>
                    productCriteriaDto.CategoryId.Any(t => t == x.CategoryId));
            }

            return productQuery;
        }
        //    [HttpGet]
        //    public async Task<IActionResult> GetProduct()
        //    {
        //        var product = await _context.Product.ToListAsync();

        //        return View(product);
        //    }
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        var productdetail = await _context.Product
        //            .FirstAsync(x => x.Id == id);

        //        if (productdetail == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(productdetail);
        //    }


        //    //[Authorize] Making code for admin
        //    public async Task<IActionResult> Create(Product product)
        //    {
        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        return View();
        //    }

        //    [HttpGet]
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var product = await _context.Product.FindAsync(id);
        //        if (product == null)
        //        {
        //            return NotFound();
        //        }
        //        ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Name", product.CategoryId);
        //        return View(product);
        //    }

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, Product product)
        //    {
        //        if (id != product.Id)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(product);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!ProductExists(product.Id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "Id", "Id", product.CategoryId);
        //        return View(product);
        //    }
        //    //[HttpGet]
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var product = await _context.Product
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (product == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(product);
        //    }

        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var product = await _context.Product.FindAsync(id);
        //        _context.Product.Remove(product);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool ProductExists(int id)
        //    {
        //        return _context.Product.Any(e => e.Id == id);
        //    }
    }
}
