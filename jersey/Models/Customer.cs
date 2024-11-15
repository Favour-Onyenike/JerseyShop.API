using System.ComponentModel.DataAnnotations;
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

        [MaxLength(15)]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must not be 11 characters.")]
        public string Phone { get; set; }

        // Navigation property
        public ICollection<Order> Orders { get; set; }
    }
}

