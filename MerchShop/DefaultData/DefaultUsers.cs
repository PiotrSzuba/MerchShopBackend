using MerchShop.Data;
using MerchShop.Models;

namespace MerchShop.DefaultData
{
    public class DefaultUsers
    {
        public static void Initialize(MerchShopContext context)
        {
            if (context.User.Any())
            {
                return;
            }
            context.User.AddRange(

            );
            context.SaveChanges();
        }
    }
}
