using MerchShop.Data;
using MerchShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MerchShop.DefaultData
{
    public class DefaultOrderedItems
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderedItem>().HasData(
                new OrderedItem
                {
                    Id = 1,
                    GenericItemId = 1,
                    OrderId = 1
                },
                new OrderedItem
                {
                    Id = 2,
                    GenericItemId = 2,
                    OrderId = 1
                },
                new OrderedItem
                {
                    Id = 3,
                    GenericItemId = 1,
                    OrderId = 2
                },
                new OrderedItem
                {
                    Id = 4,
                    GenericItemId = 1,
                    OrderId = 2
                },
                new OrderedItem
                {
                    Id = 5,
                    GenericItemId = 3,
                    OrderId = 3
                }
            );
        }
    }
}
