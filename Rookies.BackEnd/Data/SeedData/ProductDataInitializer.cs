using Microsoft.EntityFrameworkCore;
using Rookies.BackEnd.Models;
using Rookies.ShareClassdLibrary.Enum;
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
                    Price = 10000,
                    Description = "2021 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Test Product 2",
                    Price = 20000,
                    Description = "2022 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Test Product 3",
                    Price = 30000,
                    Description = "2023 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                }, new Product
                {
                    Id = 4,
                    Name = "Test Product 4",
                    Price = 40000,
                    Description = "2024 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 2
                }, new Product
                {
                    Id = 5,
                    Name = "Test Product 5",
                    Price = 50000,
                    Description = "2025 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 2
                }, new Product
                {
                    Id = 6,
                    Name = "Test Product 6",
                    Price = 60000,
                    Description = "2026 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                }, new Product
                {
                    Id = 7,
                    Name = "Test Product 7",
                    Price = 70000,
                    Description = "2027 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                }, new Product
                {
                    Id = 8,
                    Name = "Test Product 8",
                    Price = 80000,
                    Description = "2028 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                }, new Product
                {
                    Id = 9,
                    Name = "Test Product 9",
                    Price = 90000,
                    Description = "2029 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 10,
                    Name = "Test Product 10",
                    Price = 100000,
                    Description = "2030 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 11,
                    Name = "Test Product 11",
                    Price = 110000,
                    Description = "2031 Product",
                    CreatedDate = DateTime.Now,
                    CategoryId = 1
                });
        }
    }
}
