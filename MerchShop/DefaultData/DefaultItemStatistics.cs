using MerchShop.Data;
using MerchShop.Models;

namespace MerchShop.DefaultData
{
    public class DefaultItemStatistics
    {
        public static void Initialize(MerchShopContext context)
        {
            if (context.ItemStatistics.Any())
            {
                return;
            }
            context.GenericItem.AddRange(

            );
            context.SaveChanges();
        }
    }
}
