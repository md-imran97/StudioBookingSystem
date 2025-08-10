using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioBookingSystem.Common.EntityModel;
using StudioBookingSystem.Repository.Repository;
using StudioBookingSystem.Repository.RepositoryInterface;
using StudioBookingSystem.Repository.UnitOfWork;
using StudioBookingSystem.Service.Interface;

namespace StudioBookingSystem.Service.Service
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BookingService(IBookingRepository bookingRepository, IUnitOfWork unitOfWork)
        {
            _bookingRepository=bookingRepository;
            _unitOfWork=unitOfWork;
        }

        public Task CreateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Booking>> GetBookings()
        {
            return await _bookingRepository.GetAll();
        }

        public Task<List<Booking>> GetBookingsByAvailablity(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
