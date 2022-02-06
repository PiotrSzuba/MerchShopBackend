﻿// <auto-generated />
using System;
using MerchShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MerchShop.Migrations
{
    [DbContext(typeof(MerchShopContext))]
    [Migration("20220206223212_Fixed_statsV4")]
    partial class Fixed_statsV4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MerchShop.Models.GenericItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DiscountValue")
                        .HasColumnType("int");

                    b.Property<bool?>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool?>("OnDiscount")
                        .HasColumnType("bit");

                    b.Property<byte[]>("PreviewImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("GenericItem");
                });

            modelBuilder.Entity("MerchShop.Models.ItemStatistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("BoughtOnSale")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BoughtTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BuyersCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenericItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenericItemId")
                        .IsUnique();

                    b.ToTable("ItemStatistics");
                });

            modelBuilder.Entity("MerchShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("ShippingAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShippingAddressId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MerchShop.Models.OrderedItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GenericItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenericItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderedItem");
                });

            modelBuilder.Entity("MerchShop.Models.ShippingAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ShippingAddress");
                });

            modelBuilder.Entity("MerchShop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MerchShop.Models.ItemStatistics", b =>
                {
                    b.HasOne("MerchShop.Models.GenericItem", "GenericItem")
                        .WithOne("ItemStatistic")
                        .HasForeignKey("MerchShop.Models.ItemStatistics", "GenericItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenericItem");
                });

            modelBuilder.Entity("MerchShop.Models.Order", b =>
                {
                    b.HasOne("MerchShop.Models.ShippingAddress", "ShippingAddress")
                        .WithOne("Order")
                        .HasForeignKey("MerchShop.Models.Order", "ShippingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MerchShop.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("ShippingAddress");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MerchShop.Models.OrderedItem", b =>
                {
                    b.HasOne("MerchShop.Models.GenericItem", "GenericItem")
                        .WithMany("Items")
                        .HasForeignKey("GenericItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MerchShop.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenericItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MerchShop.Models.ShippingAddress", b =>
                {
                    b.HasOne("MerchShop.Models.User", "User")
                        .WithMany("ShippingAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MerchShop.Models.GenericItem", b =>
                {
                    b.Navigation("ItemStatistic");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("MerchShop.Models.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("MerchShop.Models.ShippingAddress", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("MerchShop.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ShippingAddresses");
                });
#pragma warning restore 612, 618
        }
    }
}
