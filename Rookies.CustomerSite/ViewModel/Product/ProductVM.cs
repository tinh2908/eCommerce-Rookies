using System;
using System.ComponentModel.DataAnnotations;

namespace Rookie.CustomerSite.ViewModel.Product
{
    public class ProductVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}
