using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rookies.BackEnd.Data;
using Rookies.BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult<PagedResponseDto<ProductDto>>> GetProducts(
            [FromQuery] ProductCriteriaDto productCriteriaDto,
            CancellationToken cancellationToken)
        {
            var productQuery = _context
                                .Product
                                .Where(x => !x.IsDeleted)
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
        [AllowAnonymous]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult<ProductVM>> GetProduct(int id)
        {
            var product = await _context
                                .Product
                                .Where(x => !x.IsDeleted && x.Id == id)
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
                UpdatedDate = product.UpdatedDate,
                CategoryId = (int)product.CategoryId
            };

            return productVM;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<ProductDto>> PostProduct(string name, int price, string description)
        {
            var product = new Product
            {
                Name = name,
                Price = price,
                CreatedDate = DateTime.Now,
                Description = description
            };
            _context.Product.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id },
                new ProductDto { Name = product.Name, Price = product.Price
                , CreatedDate = product.CreatedDate, Description = product.Description});
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            _context.Product.Update(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            product.IsDeleted = true;
            _context.Product.Update(product);
            await _context.SaveChangesAsync();

            return Ok(true);
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
    }
}
