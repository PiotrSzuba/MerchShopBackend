#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MerchShop.Models;
using MerchShop.DefaultData;

namespace MerchShop.Data
{
    public class MerchShopContext : DbContext
    {
        private static void SeedDatabase(ModelBuilder modelBuilder)
        {
            DefaultUsers.Initialize(modelBuilder);
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
            SeedDatabase(modelBuilder);
        }

        public DbSet<GenericItem> GenericItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderedItem> OrderedItem { get; set; }
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ItemStatistics> ItemStatistics { get; set; }
    }
}
