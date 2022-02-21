using System.ComponentModel.DataAnnotations;

namespace Rookie.CustomerSite.ViewModel.Product
{
    public class ProductVM
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
