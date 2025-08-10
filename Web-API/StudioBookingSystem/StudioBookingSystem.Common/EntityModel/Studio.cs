using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioBookingSystem.Common.EntityModel
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        // Navigation properties
        public Location Location { get; set; } = new Location();
        public Contact Contact { get; set; } = new Contact();
        public ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();
        public string Description { get; set; } = string.Empty;
        public decimal PricePerHour { get; set; }
        public string Currency { get; set; } = string.Empty;
        public Availability Availability { get; set; } = new Availability();
        public double Rating { get; set; }
        public ICollection<StudioImage> Images { get; set; } = new List<StudioImage>();
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
