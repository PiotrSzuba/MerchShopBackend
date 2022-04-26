using System.ComponentModel.DataAnnotations;

namespace MerchShop.Models
{
    public class ItemStatistics
    {
        [Key]
        public int ItemStatisticsId { get; set; }
        public int GenericItemId { get; set; }
        public DateTime BoughtTime { get; set; }
        public string? BuyersCountry { get; set; }
        public bool BoughtOnSale { get; set; }
        public virtual GenericItem? GenericItem { get; set; }
    }
}
