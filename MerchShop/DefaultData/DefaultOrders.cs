using MerchShop.Data;
using MerchShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MerchShop.DefaultData
{
    public class DefaultOrders
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    ShippingAddressId = 1,
                    UserId = 1,
                    OrderStatus = 4,
                    OrderDateTime = DateTime.Now.AddDays(1),
                },
                new Order
                {
                    Id = 2,
                    ShippingAddressId = 1,
                    UserId = 1,
                    OrderStatus = 3,
                    OrderDateTime = DateTime.Now.AddDays(3),
                },
                new Order
                {
                    Id = 3,
                    ShippingAddressId = 2,
                    UserId = 2,
                    OrderStatus = 4,
                    OrderDateTime = DateTime.Now.AddDays(1),
                },
                new Order
                {
                    Id = 4,
                    ShippingAddressId = 3,
                    UserId = 3,
                    OrderStatus = 2,
                    OrderDateTime = DateTime.Now.AddDays(4),
                },
                new Order
                {
                    Id = 5,
                    ShippingAddressId = 3,
                    UserId = 3,
                    OrderStatus = 1,
                    OrderDateTime = DateTime.Now
                }
            );
        }
    }
}
