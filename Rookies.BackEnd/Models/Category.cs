using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public virtual List<Product> Product { get; set; }
    }
}
