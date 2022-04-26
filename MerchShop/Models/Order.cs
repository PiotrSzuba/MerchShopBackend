using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MerchShop.Models;

namespace MerchShop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int ShippingAddressId { get; set; }
        public int? UserId { get; set; }
        public int OrderStatus { get; set; }
        public DateTime OrderDateTime { get; set; }
        public virtual ShippingAddress? ShippingAddress { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<OrderedItem>? Items { get; set; }
    }
}
