using Microsoft.EntityFrameworkCore;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Data.SeedData
{
    public static class RatingDataInitializer
    {
        public static void SeedRatingData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasData(
               new Rating
               {
                   Id = 1,
                   RatingScore = 5,
                   ProductId = 1
               },
               new Rating
               {
                   Id = 2,
                   RatingScore = 5,
                   ProductId = 2
               });
        }
    }
}
