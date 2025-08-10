using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioBookingSystem.Common.EntityModel
{
    public class Availability
    {
        public int Id { get; set; }
        public TimeSpan Open { get; set; }
        public TimeSpan Close { get; set; }

        public int StudioId { get; set; }
        public Studio Studio { get; set; }
    }
}
