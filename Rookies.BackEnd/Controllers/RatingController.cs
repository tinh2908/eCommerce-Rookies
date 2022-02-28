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

        [HttpGet("{ratingscore}")]
        [AllowAnonymous]
        public async Task<ActionResult<RatingDto>> PostRating(int ratingscore, int productid, int userid)
        {
            var rating = new Rating()
            {
                RatingScore = ratingscore,
                ProductId = productid,
                UserId = userid
            };

            var ratingDtos = _mapper.Map<IEnumerable<RatingDto>>(rating);
            _context.Rating.Add(rating);
            await _context.SaveChangesAsync();
            return Ok(ratingDtos);
        }
    }
}
