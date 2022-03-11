using System.ComponentModel.DataAnnotations;
using Rookies.ShareClassdLibrary.Enum;

namespace RookieShop.Shared
{
    public class ProductCreateRequest
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public ProductTypeEnum Type { get; set; }
    }
}
