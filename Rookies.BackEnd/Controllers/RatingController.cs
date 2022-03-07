using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rookies.BackEnd.Data;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Dto.Rating;
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
                                .FirstOrDefault();

            if (rating == null)
            {
                return NotFound();
            }

            var ratingDto = _mapper.Map<RatingDto>(rating);

            return Ok(ratingDto);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<RatingDto>> PostRating(RatingDto ratingDto)
        {
            var rating = new Rating
            {
                RatingScore = ratingDto.RatingScore,
                ProductId = ratingDto.ProductId
            };
            _context.Rating.Add(rating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRating", new { id = rating.Id }, 
                new RatingDto { RatingScore = rating.RatingScore, ProductId = rating.ProductId});
        }
    }
}
