using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MerchShop.Models
{
    public class ItemDetails
    {
        [Key]
        public int ItemDetailsId { get; set; }
        public ICollection<string>? Sizes { get; set; }
        public string? MainDescription { get; set; }
        public ICollection<string>? Features { get; set; }
        public string? Designer { get; set; }
        public ICollection<string>? Images { get; set; }
        public string? Category { get; set; }
        public ICollection<string>? Details { get; set; }
        public ICollection<string>? AdditionalInformation { get; set; }
    }
}
