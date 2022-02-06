using Microsoft.Extensions.DependencyInjection;
using MerchShop.Data;
using MerchShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MerchShop.DefaultData
{
    public class DefaultGenericItems
    {
        public static void Initialize(MerchShopContext context)
        {
            if (context.GenericItem.Any())
            {
                return;
            }
            context.GenericItem.AddRange(
                new GenericItem
                {
                    Name = "STD shirt",
                    Price = Convert.ToDecimal(79.0),
                    OnDiscount = false,
                    DiscountValue = 0,
                    IsInStock = true,
                    PreviewImage = null
                },
                new GenericItem
                {
                    Name = "Better jeans",
                    Price = Convert.ToDecimal(150.0),
                    OnDiscount = false,
                    DiscountValue = 0,
                    IsInStock = true,
                    PreviewImage = null
                },
                new GenericItem
                {
                    Name = "Basic hoodie",
                    Price = Convert.ToDecimal(240.0),
                    OnDiscount = false,
                    DiscountValue = 0,
                    IsInStock = true,
                    PreviewImage = null
                }
                );
            context.SaveChanges();
        }
    }
}
