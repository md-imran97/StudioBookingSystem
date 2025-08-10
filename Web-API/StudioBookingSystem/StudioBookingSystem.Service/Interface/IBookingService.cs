using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioBookingSystem.Common.EntityModel;

namespace StudioBookingSystem.Service.Interface
{
    public interface IBookingService
    {
        Task<List<Booking>> GetBookings();
        Task CreateBooking(Booking booking);
        Task<List<Booking>> GetBookingsByAvailablity(DateTime date);
    }
}
