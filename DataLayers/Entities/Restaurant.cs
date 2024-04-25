using System.ComponentModel.DataAnnotations;

namespace Delivery.DataLayers.Entities
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [MaxLength]
        public string Address { get; set; } = string.Empty;
        [MaxLength]
        public string ContactInformation { get; set; } = string.Empty;
        [MaxLength]
        public string? OpeningHours { get; set; } = string.Empty;
        public ICollection<MenuItem>? MenuItems { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
