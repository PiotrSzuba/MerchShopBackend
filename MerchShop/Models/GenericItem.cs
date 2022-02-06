using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MerchShop.Models
{
    public class GenericItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string? Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public bool? OnDiscount { get; set; }
        public int? DiscountValue { get; set; }
        public bool? IsInStock { get; set; }
        public byte[]? PreviewImage { get; set; }

        public virtual ICollection<OrderedItem>? Items { get; set; }
        public virtual ItemStatistics? ItemStatistic { get; set; }
    }
}
