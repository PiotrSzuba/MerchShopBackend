#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MerchShop.Models;
using MerchShop.DefaultData;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MerchShop.Data
{
    public class MerchShopContext : DbContext
    {
        private static void SeedDatabase(ModelBuilder modelBuilder)
        {
            DefaultUsers.Initialize(modelBuilder);
            DefaultItemDetails.Initialize(modelBuilder);
            DefaultGenericItems.Initialize(modelBuilder);
            DefaultShippingAddresses.Initialize(modelBuilder);
            DefaultOrders.Initialize(modelBuilder);
            DefaultOrderedItems.Initialize(modelBuilder);
            DefaultItemStatistics.Initialize(modelBuilder);
        }

        public MerchShopContext (DbContextOptions<MerchShopContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ItemDetails>().Property(P => P.Sizes).HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
                new ValueComparer<ICollection<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => (ICollection<string>)c.ToList()));

            modelBuilder.Entity<ItemDetails>().Property(P => P.Features).HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
                new ValueComparer<ICollection<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => (ICollection<string>)c.ToList()));

            modelBuilder.Entity<ItemDetails>().Property(P => P.Images).HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
                new ValueComparer<ICollection<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => (ICollection<string>)c.ToList()));

            modelBuilder.Entity<ItemDetails>().Property(P => P.Details).HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
                new ValueComparer<ICollection<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => (ICollection<string>)c.ToList()));

            modelBuilder.Entity<ItemDetails>().Property(P => P.AdditionalInformation).HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
                new ValueComparer<ICollection<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => (ICollection<string>)c.ToList()));

            SeedDatabase(modelBuilder);
        }

        public DbSet<GenericItem> GenericItem { get; set; }
        public DbSet<ItemDetails> ItemDetails { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderedItem> OrderedItem { get; set; }
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ItemStatistics> ItemStatistics { get; set; }
    }
}
