using MerchShop.Data;
using MerchShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MerchShop.DefaultData
{
    public class DefaultItemStatistics
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemStatistics>().HasData(
                new ItemStatistics
                {
                    Id = 1,
                    GenericItemId = 1,
                    BoughtTime = DateTime.Now.AddDays(1),
                    BuyersCountry = "PL",
                    BoughtOnSale = false
                },
                new ItemStatistics
                {
                    Id = 2,
                    GenericItemId = 1,
                    BoughtTime = DateTime.Now.AddDays(2),
                    BuyersCountry = "PL",
                    BoughtOnSale = false
                },
                new ItemStatistics
                {
                    Id = 3,
                    GenericItemId = 1,
                    BoughtTime = DateTime.Now.AddDays(3),
                    BuyersCountry = "PL",
                    BoughtOnSale = true
                },
                new ItemStatistics
                {
                    Id = 4,
                    GenericItemId = 2,
                    BoughtTime = DateTime.Now.AddDays(0),
                    BuyersCountry = "PL",
                    BoughtOnSale = false
                },
                new ItemStatistics
                {
                    Id = 5,
                    GenericItemId = 2,
                    BoughtTime = DateTime.Now.AddDays(1),
                    BuyersCountry = "PL",
                    BoughtOnSale = false
                },
                new ItemStatistics
                {
                    Id = 6,
                    GenericItemId = 3,
                    BoughtTime = DateTime.Now.AddDays(1),
                    BuyersCountry = "PL",
                    BoughtOnSale = false
                },
                new ItemStatistics
                {
                    Id = 7,
                    GenericItemId = 3,
                    BoughtTime = DateTime.Now.AddDays(2),
                    BuyersCountry = "PL",
                    BoughtOnSale = false
                },
                new ItemStatistics
                {
                    Id = 8,
                    GenericItemId = 3,
                    BoughtTime = DateTime.Now.AddDays(3),
                    BuyersCountry = "PL",
                    BoughtOnSale = true
                }
            );
        }
    }
}
