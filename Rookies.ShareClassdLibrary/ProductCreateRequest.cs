using System.ComponentModel.DataAnnotations;
using Rookies.ShareClassdLibrary.Enum;

namespace RookieShop.Shared
{
    public class ProductCreateRequest
    {
        [Required]
        public string Name { get; set; }
        public ProductCategoryEnum CategoryId { get; set; }
    }
}
