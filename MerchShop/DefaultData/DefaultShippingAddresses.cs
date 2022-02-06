using MerchShop.Data;
using MerchShop.Models;

namespace MerchShop.DefaultData
{
    public class DefaultShippingAddresses
    {
        public static void Initialize(MerchShopContext context)
        {
            if (context.ShippingAddress.Any())
            {
                return;
            }
            context.ShippingAddress.AddRange(

            );
            context.SaveChanges();
        }
    }
}
