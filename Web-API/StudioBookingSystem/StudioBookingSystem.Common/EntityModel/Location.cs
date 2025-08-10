using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioBookingSystem.Common.EntityModel
{
    public class Location
    {
        public int Id { get; set; }
        public string City { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int CoordinatesId { get; set; }
        public Coordinates Coordinates { get; set; }

        // Foreign Key
        public int StudioId { get; set; }
        public Studio Studio { get; set; }
    }
}
