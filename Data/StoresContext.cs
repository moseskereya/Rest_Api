using Microsoft.EntityFrameworkCore;
using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Data
{
    public class StoresContext : DbContext
    {
        public StoresContext(DbContextOptions<StoresContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Computer & Office"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Clothing"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Shoe"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Luggage & Bags"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Watch & Jewelry"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Home & Appliances"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Phones & Tel"
                }
               );
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductID = 1,
                ProductName = "Keyboards",
                Description = "sweet 2.4G Ultra Slim wireless keyboard Portable Mute Keys Keyboards mouse combos for Mac Win XP 7 wireless Keyboard and mouse",
                ImagePath = "image1.jpeg",
                UnitPrice = 60000.78M,
                CategoryID = 1,
                AvailableQuantity = 12
            },
            new Product
            {
                ProductID = 2,
                ProductName = "Wireless Keyboard and Mouse Mini Multimedia",
                Description = "Wireless Keyboard  Ultra Slim wireless keyboard Portable Mute Keys Keyboards mouse combos for Mac Win XP 7 wireless Keyboard and mouse",
                ImagePath = "image12.jpeg",
                UnitPrice = 70000.11M,
                CategoryID = 1,
                AvailableQuantity = 100

            },
            new Product
            {
                ProductID = 3,
                ProductName = "Simple Fashion Casual Business Watches",
                Description = "Get one of these whatch. You will love it. This will change your life style",
                ImagePath = "whatch2.jpeg",
                UnitPrice = 30000.8M,
                CategoryID = 5,
                AvailableQuantity = 0
            },
            new Product
            {
                ProductID = 5,
                ProductName = "SKMEI Luxury Men Watch Fashion Casual Watches",
                Description = "Get one of these whatch. You will love it. This will change your life style",
                ImagePath = "whatch1.jpeg",
                UnitPrice = 40000.0M,
                CategoryID = 5,
                AvailableQuantity = 0

            },
            new Product
            {
                ProductID = 6,
                ProductName = "296 calendar men's watch waterproof quartz watch",
                Description = "296 calendar men's watch waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.",
                ImagePath = "whatch3.jpeg",
                UnitPrice = 10000.0M,
                CategoryID = 5,
                AvailableQuantity = 150
            },
            new Product
            {
                ProductID = 7,
                ProductName = "Men watches casual sports watch",
                Description = "Men watches casual sports watch is a waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.",
                ImagePath = "whatch4.jpeg",
                UnitPrice = 14000.8M,
                CategoryID = 5,
                AvailableQuantity = 1
            },
            new Product
            {
                ProductID = 8,
                ProductName = "Men fashion business brogue suede dress shoes",
                Description = "Business brogue suede dress shoes is affordable and clean shoe you wou;d like to have and enjoy it.",
                ImagePath = "s1.jpeg",
                UnitPrice = 20000.90M,
                CategoryID = 2,
                AvailableQuantity = 0
            },
            new Product
            {
                ProductID = 9,
                ProductName = "Leisure Shoes",
                Description = "Men's Shoes Fall 2019 Sports Shoes Men's Fashion Leisure Shoes A Generic PU Small White Shoe",
                ImagePath = "s2.jpeg",
                UnitPrice = 20000.90M,
                AvailableQuantity = 80,
                CategoryID = 2
             }
            );
             base.OnModelCreating(modelBuilder);
            }
        }
    }
