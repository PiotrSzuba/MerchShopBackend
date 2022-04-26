using Microsoft.Extensions.DependencyInjection;
using MerchShop.Data;
using MerchShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MerchShop.DefaultData
{
    public class DefaultItemDetails
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemDetails>().HasData(
                new ItemDetails
                {
                    ItemDetailsId = 1,
                    Sizes = new string[] {"XS","S","M","L","XL"},
                    MainDescription = null,
                    Features = null,
                    Designer = null,
                    Images = null,
                    Category = null,
                    Details = null,
                    AdditionalInformation = null
                },
                new ItemDetails
                {
                    ItemDetailsId = 2,
                    Sizes = new string[] { "XS", "S", "M", "L", "XL", "XXL" },
                    MainDescription = null,
                    Features = null,
                    Designer = null,
                    Images = null,
                    Category = null,
                    Details = null,
                    AdditionalInformation = null
                },
                new ItemDetails
                {
                    ItemDetailsId = 3,
                    Sizes = new string[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" },
                    MainDescription = null,
                    Features = null,
                    Designer = null,
                    Images = null,
                    Category = null,
                    Details = null,
                    AdditionalInformation = null
                }
            );
        }
    }
}
