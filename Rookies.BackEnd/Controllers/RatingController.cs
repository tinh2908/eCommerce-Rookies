using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rookies.BackEnd.Data;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Dto.Raing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RatingController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public ActionResult<RatingDto> GetRating(int id)
        {
            var rating = _context
                                .Rating
                                .Where(x => x.Id == id)
                                .AsQueryable();

            if (rating == null)
            {
                return NotFound();
            }

            var ratingDtos = _mapper.Map<IEnumerable<RatingDto>>(rating);

            return Ok(ratingDtos);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<RatingDto>> PostRating(int ratingscore, int productid)
        {
            var rating = new Rating
            {
                RatingScore = ratingscore,
                ProductId = productid
            };
            _context.Rating.Add(rating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRating", new { id = rating.Id }, 
                new RatingDto { ProductId = rating.ProductId});
        }
    }
}
