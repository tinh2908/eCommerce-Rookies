using Microsoft.EntityFrameworkCore;
using Rookies.BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Data.SeedData
{
    public static class ProductDataInitializer
    {
        public static void SeedProductData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Test Product 1",
                    Description = "2022 Product",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
