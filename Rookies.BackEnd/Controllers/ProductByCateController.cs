using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rookies.BackEnd.Data;
using Rookies.ShareClassdLibrary.Dto.ProductbyCate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductByCateController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductByCateController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
    }
}
