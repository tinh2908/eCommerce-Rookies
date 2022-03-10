using System;

namespace Rookies.ShareClassdLibrary
{
    public class ProductVM 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Type { get; set; }
        public int CategoryId { get; set; }
    }
}
