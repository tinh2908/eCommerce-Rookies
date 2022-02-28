using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int RatingScore { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
