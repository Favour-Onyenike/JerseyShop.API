using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace jersey.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        [JsonIgnore]
        public Customer? Customer { get; set; }

        // Make Payments optional
        [JsonIgnore]
        public ICollection<Payment>? Payments { get; set; } = new List<Payment>(); // Default to an empty list to avoid null reference issues
    }
}
