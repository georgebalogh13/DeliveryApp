using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.DataLayers.Entities
{
    public class MenuItem
    {
        [Key]
        public int ProductID { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [MaxLength(50)]
        public string? Category { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantID_MenuItem { get; set; }
        //Schimbarea denumirii cheiei straine la menuitem si order 
        //este deoarece nu putem avea acelasi nume de cheie straina la 2 entitati diferite

        public Restaurant? Restaurant { get; set; }
    }
}
