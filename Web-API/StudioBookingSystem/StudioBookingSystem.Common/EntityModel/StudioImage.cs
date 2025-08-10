using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioBookingSystem.Common.EntityModel
{
    public class StudioImage
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        public int StudioId { get; set; }
        public Studio Studio { get; set; }
    }
}
