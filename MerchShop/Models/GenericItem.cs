using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MerchShop.Models
{
    public class GenericItem
    {
        [Key]
        public int GenericItemId { get; set; }
        [ForeignKey("ItemDetails")]
        public int ItemDetailsId { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string? Name { get; set; }
        [Required]
        //[Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public bool? OnDiscount { get; set; }
        public int? DiscountValue { get; set; }
        public bool? IsInStock { get; set; }
        [Column(TypeName = "varbinary(max)")]
        public byte[]? PreviewImage { get; set; }

        public virtual ICollection<OrderedItem>? Items { get; set; }
        public virtual ICollection<ItemStatistics>? ItemStatistics { get; set; }
        public virtual ItemDetails? ItemDetails { get; set; }
    }
}
