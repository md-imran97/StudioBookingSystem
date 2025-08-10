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
        private readonly IStudioRepository _studioRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BookingService(IBookingRepository bookingRepository, IStudioRepository studioRepository,
            IUnitOfWork unitOfWork)
        {
            _bookingRepository=bookingRepository;
            _studioRepository=studioRepository;
            _unitOfWork=unitOfWork;
        }

        public async Task CreateBooking(Booking booking)
        {
            // Check availablity

            // if ok
            _bookingRepository.Add(booking);
           await _unitOfWork.SaveChanges();
            
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
