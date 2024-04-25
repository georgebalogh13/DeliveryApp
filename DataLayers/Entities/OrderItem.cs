using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataLayers.Entities
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Subtotal { get; set; }
        public Order? Order { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public MenuItem? MenuItem { get; set; }

        [ForeignKey("MenuItem")]
        public int MenuItemId { get; set; }
    }
}