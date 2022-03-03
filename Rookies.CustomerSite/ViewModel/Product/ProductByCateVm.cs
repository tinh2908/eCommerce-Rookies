using System;
using System.ComponentModel.DataAnnotations;

namespace Rookies.CustomerSite.ViewModel.Product
{
    public class ProductByCateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}
