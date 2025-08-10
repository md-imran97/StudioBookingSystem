using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioBookingSystem.Common.EntityModel;
using StudioBookingSystem.Repository.Repository;
using StudioBookingSystem.Repository.RepositoryInterface;
using StudioBookingSystem.Service.Interface;

namespace StudioBookingSystem.Service.Service
{
    public class StudioService : IStudioService
    {
        private readonly IStudioRepository _studioRepository;

        public  StudioService(IStudioRepository studioRepository)
        {
            _studioRepository = studioRepository;
        }
        public async Task<Studio> GetStudioByArea(double lat, double radious)
        {
            throw new NotImplementedException();
        }

        public async Task<Studio> GetStudioById(int id)
        {
            return await _studioRepository.Get(id);
        }

        public async Task<List<Studio>> GetStudios()
        {
            return await _studioRepository.GetAll();
        }
    }
}
