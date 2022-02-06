using MerchShop.Data;
using MerchShop.Models;

namespace MerchShop.DefaultData
{
    public class DefaultOrders
    {
        public static void Initialize(MerchShopContext context)
        {
            if (context.Order.Any())
            {
                return;
            }
            context.Order.AddRange(

            );
            context.SaveChanges();
        }
    }
}
