using System.ComponentModel.DataAnnotations;

namespace Delivery.DataLayers.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        /*        public string Password { get; set; } = string.Empty;*/
        [MaxLength(30)]
        public string PhoneNumber { get; set; } = string.Empty;
        [MaxLength]
        public string Address { get; set; } = string.Empty;

        public ICollection<Order>? Orders { get; set; }
    }
}
