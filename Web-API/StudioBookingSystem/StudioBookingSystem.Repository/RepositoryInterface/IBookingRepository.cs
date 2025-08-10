using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioBookingSystem.Common.EntityModel;

namespace StudioBookingSystem.Repository.RepositoryInterface
{
    public interface IBookingRepository:IRepository<Booking,int>
    {
    }
}
