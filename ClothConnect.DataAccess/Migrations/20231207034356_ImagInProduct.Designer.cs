﻿// <auto-generated />
using ClothConnect.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothConnect.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231207034356_ImagInProduct")]
    partial class ImagInProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClothConnect.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 5,
                            Name = "Gown"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Jacket"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Dress"
                        });
                });

            modelBuilder.Entity("ClothConnect.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Seller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Exquisite evening gown perfect for gala events. Features a sleek silhouette and luxurious fabric that gracefully flows to the floor.",
                            ImageUrl = "",
                            ItemCode = "ELEG001122",
                            ListPrice = 120.0,
                            Price = 115.0,
                            Price100 = 105.0,
                            Price50 = 110.0,
                            Seller = "Sophia Lorenz",
                            Title = "Elegant Evening Gown"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "A timeless leather jacket, ideal for adding an edge to any outfit. Made with premium quality leather for durability and style.",
                            ImageUrl = "",
                            ItemCode = "CLJ8889002",
                            ListPrice = 200.0,
                            Price = 190.0,
                            Price100 = 170.0,
                            Price50 = 180.0,
                            Seller = "Mike Johnson",
                            Title = "Classic Leather Jacket"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Flowy and light, this maxi dress is perfect for sunny days. Features a floral print and a comfortable, airy design.",
                            ImageUrl = "",
                            ItemCode = "SBMD5555003",
                            ListPrice = 80.0,
                            Price = 75.0,
                            Price100 = 65.0,
                            Price50 = 70.0,
                            Seller = "Luna Rodriguez",
                            Title = "Summer Breeze Maxi Dress"
                        });
                });

            modelBuilder.Entity("ClothConnect.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("ClothConnect.Models.Product", b =>
                {
                    b.HasOne("ClothConnect.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClothConnect.Models.ProductImage", b =>
                {
                    b.HasOne("ClothConnect.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}