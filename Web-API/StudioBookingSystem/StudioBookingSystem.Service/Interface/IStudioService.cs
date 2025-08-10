using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioBookingSystem.Common.EntityModel;

namespace StudioBookingSystem.Service.Interface
{
    public interface IStudioService
    {
        Task<List<Studio>> GetStudios();
        Task<Studio> GetStudioById(int id);
        Task<Studio> GetStudioByArea(double lat,double radious);
    }
}
