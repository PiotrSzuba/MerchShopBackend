using System.ComponentModel.DataAnnotations;
using MerchShop.Models;

namespace MerchShop.Models
{
    public class OrderedItem
    {
        [Key]
        public int OrderedItemId { get; set; }
        public int GenericItemId { get; set; }
        public virtual GenericItem? GenericItem { get; set; }
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
    }
}
