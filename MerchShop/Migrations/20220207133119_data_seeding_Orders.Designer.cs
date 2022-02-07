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
    [Migration("20220207133119_data_seeding_Orders")]
    partial class data_seeding_Orders
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
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("GenericItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountValue = 0,
                            IsInStock = true,
                            Name = "STD shirt",
                            OnDiscount = false,
                            Price = 79.99m
                        },
                        new
                        {
                            Id = 2,
                            DiscountValue = 0,
                            IsInStock = true,
                            Name = "Better jeans",
                            OnDiscount = false,
                            Price = 150.99m
                        },
                        new
                        {
                            Id = 3,
                            DiscountValue = 0,
                            IsInStock = true,
                            Name = "Basic hoodie",
                            OnDiscount = false,
                            Price = 240.99m
                        });
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

                    b.HasIndex("GenericItemId");

                    b.ToTable("ItemStatistics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BoughtOnSale = false,
                            BoughtTime = new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8260),
                            BuyersCountry = "PL",
                            GenericItemId = 1
                        },
                        new
                        {
                            Id = 2,
                            BoughtOnSale = false,
                            BoughtTime = new DateTime(2022, 2, 9, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8267),
                            BuyersCountry = "PL",
                            GenericItemId = 1
                        },
                        new
                        {
                            Id = 3,
                            BoughtOnSale = true,
                            BoughtTime = new DateTime(2022, 2, 10, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8270),
                            BuyersCountry = "PL",
                            GenericItemId = 1
                        },
                        new
                        {
                            Id = 4,
                            BoughtOnSale = false,
                            BoughtTime = new DateTime(2022, 2, 7, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8273),
                            BuyersCountry = "PL",
                            GenericItemId = 2
                        },
                        new
                        {
                            Id = 5,
                            BoughtOnSale = false,
                            BoughtTime = new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8276),
                            BuyersCountry = "PL",
                            GenericItemId = 2
                        },
                        new
                        {
                            Id = 6,
                            BoughtOnSale = false,
                            BoughtTime = new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8280),
                            BuyersCountry = "PL",
                            GenericItemId = 3
                        },
                        new
                        {
                            Id = 7,
                            BoughtOnSale = false,
                            BoughtTime = new DateTime(2022, 2, 9, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8283),
                            BuyersCountry = "PL",
                            GenericItemId = 3
                        },
                        new
                        {
                            Id = 8,
                            BoughtOnSale = true,
                            BoughtTime = new DateTime(2022, 2, 10, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8286),
                            BuyersCountry = "PL",
                            GenericItemId = 3
                        });
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

                    b.HasIndex("ShippingAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderDateTime = new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8042),
                            OrderStatus = 4,
                            ShippingAddressId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            OrderDateTime = new DateTime(2022, 2, 10, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8205),
                            OrderStatus = 3,
                            ShippingAddressId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            OrderDateTime = new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8212),
                            OrderStatus = 4,
                            ShippingAddressId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            OrderDateTime = new DateTime(2022, 2, 11, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8215),
                            OrderStatus = 2,
                            ShippingAddressId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 5,
                            OrderDateTime = new DateTime(2022, 2, 7, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8218),
                            OrderStatus = 1,
                            ShippingAddressId = 3,
                            UserId = 3
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentNumber = "3",
                            City = "Wrocław",
                            Country = "PL",
                            PostalCode = "50-004",
                            Region = "Dolnośląskie",
                            StreetAddress = "Smocza 5",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ApartmentNumber = "4",
                            City = "Wrocław",
                            Country = "PL",
                            PostalCode = "50-004",
                            Region = "Dolnośląskie",
                            StreetAddress = "Polna 1",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            City = "Wrocław",
                            Country = "PL",
                            PostalCode = "50-004",
                            Region = "Dolnośląskie",
                            StreetAddress = "Piękna 62",
                            UserId = 3
                        });
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "sakonir@gmail.com",
                            Name = "Piotr",
                            Password = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                            Role = "admin",
                            Surname = "Szuba",
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "sakonir2@gmail.com",
                            Name = "War",
                            Password = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                            Role = "regular",
                            Surname = "Wick",
                            UserName = "RegularUser1"
                        },
                        new
                        {
                            Id = 3,
                            Email = "sakonir3@gmail.com",
                            Name = "Ur",
                            Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                            Role = "worker",
                            Surname = "Got",
                            UserName = "RegularWorker"
                        });
                });

            modelBuilder.Entity("MerchShop.Models.ItemStatistics", b =>
                {
                    b.HasOne("MerchShop.Models.GenericItem", "GenericItem")
                        .WithMany("ItemStatistics")
                        .HasForeignKey("GenericItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenericItem");
                });

            modelBuilder.Entity("MerchShop.Models.Order", b =>
                {
                    b.HasOne("MerchShop.Models.ShippingAddress", "ShippingAddress")
                        .WithMany("Order")
                        .HasForeignKey("ShippingAddressId")
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
                    b.Navigation("ItemStatistics");

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
