using System.ComponentModel.DataAnnotations;
using Rookies.ShareClassdLibrary.Enum;

namespace RookieShop.Shared
{
    public class CategoryCreateRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
