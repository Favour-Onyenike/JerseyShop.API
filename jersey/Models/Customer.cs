using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace jersey.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [MaxLength(11)]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be 11 digits.")]
        public string Phone { get; set; }

        // Navigation property
        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; } // Made optional
    }
}
