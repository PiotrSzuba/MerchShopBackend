using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MerchShop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress,Required]
        [StringLength(64, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string? Email { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "The {0} value must be longer than {1} characters.")]
        [StringLength(32, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string? UserName { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "The {0} value must be longer than {1} characters.")]
        [StringLength(128, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string? Password { get; set; }

        [Required,MinLength(2,ErrorMessage = "The {0} value must be longer than {1} characters.")]
        public string? Role { get; set; }

        [MinLength(2, ErrorMessage = "The {0} value must be longer than {1} characters.")]
        [StringLength(32, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string? Name { get; set; }

        [MinLength(2, ErrorMessage = "The {0} value must be longer than {1} characters.")]
        [StringLength(32, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string? Surname { get; set; }

        public virtual ICollection<ShippingAddress>? ShippingAddresses { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
