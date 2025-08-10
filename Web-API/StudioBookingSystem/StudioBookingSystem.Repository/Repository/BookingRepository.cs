using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudioBookingSystem.Common.EntityModel;
using StudioBookingSystem.Repository.Database;
using StudioBookingSystem.Repository.RepositoryInterface;

namespace StudioBookingSystem.Repository.Repository
{
    public class BookingRepository : Repository<Booking, int>, IBookingRepository
    {
        public BookingRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
