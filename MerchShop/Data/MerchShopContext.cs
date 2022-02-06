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
        private void SeedDataBase()
        {
            DefaultUsers.Initialize(this);
            DefaultGenericItems.Initialize(this);
            DefaultShippingAddresses.Initialize(this);
            DefaultOrderedItems.Initialize(this);
            DefaultOrders.Initialize(this);
            DefaultItemStatistics.Initialize(this);
        }

        public MerchShopContext (DbContextOptions<MerchShopContext> options) : base(options)
        {
            SeedDataBase();
        }

        public DbSet<GenericItem> GenericItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderedItem> OrderedItem { get; set; }
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<MerchShop.Models.ItemStatistics> ItemStatistics { get; set; }
    }
}
