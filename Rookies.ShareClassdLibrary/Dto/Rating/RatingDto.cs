using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookies.ShareClassdLibrary.Dto.Raing
{
    public class RatingDto
    {
        public int Id { get; set; }
        public int RatingScore { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}
