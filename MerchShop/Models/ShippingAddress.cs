using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MerchShop.Models;

namespace MerchShop.Models
{
    public class ShippingAddress
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Country { get; set; }

        [Required]
        public string? Region { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? PostalCode { get; set; }

        [Required]
        public string? StreetAddress { get; set; }

        public string? ApartmentNumber { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Order>? Order { get; set; }
    }
}



