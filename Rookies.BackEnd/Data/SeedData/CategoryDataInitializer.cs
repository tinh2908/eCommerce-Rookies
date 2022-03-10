using Microsoft.EntityFrameworkCore;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Data.SeedData
{
    public static class CategoryDataInitializer
    {
        public static void SeedCategoryData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Category 1",
               },
               new Category
               {
                   Id = 2,
                   Name = "Category 2",
               });
        }
    }
}
