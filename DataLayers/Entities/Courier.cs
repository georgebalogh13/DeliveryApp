using System.ComponentModel.DataAnnotations;

namespace Delivery.DataLayers.Entities
{
    public class Courier
    {
        [Key]
        public int CourierID { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength(100)]
        [EmailAddress]
        public string? Email { get; set; }
        [MaxLength(30)]
        public string? PhoneNumber { get; set; }
        [MaxLength(100)]
        public string? VehicleType { get; set; }
        [MaxLength(20)]
        public string? LicensePlateNumber { get; set; }

        /*        public double CurrentLatitude { get; set; }
                public double CurrentLongitude { get; set; }*/
        public bool AvailabilityStatus { get; set; }
    }
}
