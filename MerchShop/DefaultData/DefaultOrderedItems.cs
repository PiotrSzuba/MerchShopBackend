using MerchShop.Data;
using MerchShop.Models;

namespace MerchShop.DefaultData
{
    public class DefaultOrderedItems
    {
        public static void Initialize(MerchShopContext context)
        {
            if (context.OrderedItem.Any())
            {
                return;
            }
            context.GenericItem.AddRange(

            );
            context.SaveChanges();
        }
    }
}
