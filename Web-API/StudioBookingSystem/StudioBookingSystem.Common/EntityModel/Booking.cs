using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioBookingSystem.Common.EntityModel
{
    public class Booking
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public int StudioId { get; set; }
        public Studio Studio { get; set; }
    }
}
