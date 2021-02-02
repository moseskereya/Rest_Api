﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stores.Data;

namespace Stores.Migrations
{
    [DbContext(typeof(StoresContext))]
    [Migration("20210201145940_quntitydata")]
    partial class quntitydata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Stores.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Computer & Office"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Clothing"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Shoe"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Luggage & Bags"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Watch & Jewelry"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Home & Appliances"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Phones & Tel"
                        });
                });

            modelBuilder.Entity("Stores.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(10000);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            AvailableQuantity = 12,
                            CategoryID = 1,
                            Description = "sweet 2.4G Ultra Slim wireless keyboard Portable Mute Keys Keyboards mouse combos for Mac Win XP 7 wireless Keyboard and mouse",
                            ImagePath = "image1.jpeg",
                            ProductName = "Keyboards",
                            UnitPrice = 60000.78m
                        },
                        new
                        {
                            ProductID = 2,
                            AvailableQuantity = 100,
                            CategoryID = 1,
                            Description = "Wireless Keyboard  Ultra Slim wireless keyboard Portable Mute Keys Keyboards mouse combos for Mac Win XP 7 wireless Keyboard and mouse",
                            ImagePath = "image12.jpeg",
                            ProductName = "Wireless Keyboard and Mouse Mini Multimedia",
                            UnitPrice = 70000.11m
                        },
                        new
                        {
                            ProductID = 3,
                            AvailableQuantity = 0,
                            CategoryID = 5,
                            Description = "Get one of these whatch. You will love it. This will change your life style",
                            ImagePath = "whatch2.jpeg",
                            ProductName = "Simple Fashion Casual Business Watches",
                            UnitPrice = 30000.8m
                        },
                        new
                        {
                            ProductID = 5,
                            AvailableQuantity = 0,
                            CategoryID = 5,
                            Description = "Get one of these whatch. You will love it. This will change your life style",
                            ImagePath = "whatch1.jpeg",
                            ProductName = "SKMEI Luxury Men Watch Fashion Casual Watches",
                            UnitPrice = 40000.0m
                        },
                        new
                        {
                            ProductID = 6,
                            AvailableQuantity = 150,
                            CategoryID = 5,
                            Description = "296 calendar men's watch waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.",
                            ImagePath = "whatch3.jpeg",
                            ProductName = "296 calendar men's watch waterproof quartz watch",
                            UnitPrice = 10000.0m
                        },
                        new
                        {
                            ProductID = 7,
                            AvailableQuantity = 1,
                            CategoryID = 5,
                            Description = "Men watches casual sports watch is a waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.",
                            ImagePath = "whatch4.jpeg",
                            ProductName = "Men watches casual sports watch",
                            UnitPrice = 14000.8m
                        },
                        new
                        {
                            ProductID = 8,
                            AvailableQuantity = 0,
                            CategoryID = 2,
                            Description = "Business brogue suede dress shoes is affordable and clean shoe you wou;d like to have and enjoy it.",
                            ImagePath = "s1.jpeg",
                            ProductName = "Men fashion business brogue suede dress shoes",
                            UnitPrice = 20000.90m
                        },
                        new
                        {
                            ProductID = 9,
                            AvailableQuantity = 80,
                            CategoryID = 2,
                            Description = "Men's Shoes Fall 2019 Sports Shoes Men's Fashion Leisure Shoes A Generic PU Small White Shoe",
                            ImagePath = "s2.jpeg",
                            ProductName = "Leisure Shoes",
                            UnitPrice = 20000.90m
                        });
                });

            modelBuilder.Entity("Stores.Models.Product", b =>
                {
                    b.HasOne("Stores.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}