using System;
using System.ComponentModel.DataAnnotations;

namespace Rookies.CustomerSite.ViewModel.Rating
{
    public class RatingVM
    {
        public int Id { get; set; }
        public int RatingScore { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
    }
}
