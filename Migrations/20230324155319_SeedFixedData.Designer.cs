﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Data;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230324155319_SeedFixedData")]
    partial class SeedFixedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductAPI.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductCategory")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Price = 17,
                            ProductCategory = 1,
                            ProductDescription = "Delicious chicken curry",
                            ProductImageUrl = "",
                            ProductName = "Chicken curry"
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 10,
                            ProductCategory = 0,
                            ProductDescription = "Nepalese steamed dumplings",
                            ProductImageUrl = "",
                            ProductName = "Chicken momo"
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 15,
                            ProductCategory = 1,
                            ProductDescription = "Delicious chicken leg piece cooked in fire",
                            ProductImageUrl = "",
                            ProductName = "Chicken tandoori"
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 5,
                            ProductCategory = 1,
                            ProductDescription = "Delicious sugar balls",
                            ProductImageUrl = "",
                            ProductName = "Gulab Jamun"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
