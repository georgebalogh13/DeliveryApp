using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataLayers.Entities
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderTime { get; set; }

        [MaxLength(255)]
        public string? DeliveryAddress { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        [MaxLength(50)]
        public string? OrderStatus { get; set; }

        public User? User { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public Courier? Courier { get; set; }

        [ForeignKey("Courier")]
        public int CourierID { get; set; }
        public Restaurant? Restaurant { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantID_Order { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}