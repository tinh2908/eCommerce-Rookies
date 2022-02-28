using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rookies.BackEnd.Data.SeedData;
using Rookies.BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookies.BackEnd.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Rookies.BackEnd.Models.Category> Category { get; set; }
        public DbSet<Rookies.BackEnd.Models.Product> Product { get; set; }
        public DbSet<Rookies.BackEnd.Models.Rating> Rating { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedProductData();
            modelBuilder.SeedCategoryData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
