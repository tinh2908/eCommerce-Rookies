using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public virtual List<Category> Categories { get; set; }

    }
}
