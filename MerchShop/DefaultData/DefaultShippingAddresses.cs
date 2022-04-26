using MerchShop.Data;
using MerchShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MerchShop.DefaultData
{
    public class DefaultShippingAddresses
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShippingAddress>().HasData(
                new ShippingAddress
                {
                    ShippingAddressId = 1,
                    Country = "PL",
                    Region = "Dolnośląskie",
                    City = "Wrocław",
                    PostalCode = "50-004",
                    StreetAddress = "Smocza 5",
                    ApartmentNumber = "3",
                    UserId = 1
                },
                new ShippingAddress
                {
                    ShippingAddressId = 2,
                    Country = "PL",
                    Region = "Dolnośląskie",
                    City = "Wrocław",
                    PostalCode = "50-004",
                    StreetAddress = "Polna 1",
                    ApartmentNumber = "4",
                    UserId = 2
                },
                new ShippingAddress
                {
                    ShippingAddressId = 3,
                    Country = "PL",
                    Region = "Dolnośląskie",
                    City = "Wrocław",
                    PostalCode = "50-004",
                    StreetAddress = "Piękna 62",
                    UserId = 3
                }
            );
        }
    }
}
