using Microsoft.Extensions.DependencyInjection;
using MerchShop.Data;
using MerchShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MerchShop.DefaultData
{
    public class DefaultGenericItems
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenericItem>().HasData(
                new GenericItem
                {
                    GenericItemId = 1,
                    ItemDetailsId = 1,
                    Name = "STD shirt",
                    Price = Convert.ToDecimal(79.99),
                    OnDiscount = false,
                    DiscountValue = 0,
                    IsInStock = true,
                    PreviewImage = null
                },
                new GenericItem
                {
                    GenericItemId = 2,
                    ItemDetailsId = 2,
                    Name = "Better jeans",
                    Price = Convert.ToDecimal(150.99),
                    OnDiscount = false,
                    DiscountValue = 0,
                    IsInStock = true,
                    PreviewImage = null
                },
                new GenericItem
                {
                    GenericItemId = 3,
                    ItemDetailsId = 2,
                    Name = "Basic hoodie",
                    Price = Convert.ToDecimal(240.99),
                    OnDiscount = false,
                    DiscountValue = 0,
                    IsInStock = true,
                    PreviewImage = null
                }
                );
        }
    }
}
