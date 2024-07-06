using eWellness.BL.Common;
using eWellness.Core.Parameters;
using eWellness.Core.Models;
using eWellness.DL;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class ServiceService : IServiceService
    {
        protected IServiceRepository _serviceRepository { get; set; }

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public ValueTask<EntityEntry<Service>> AddAsync(Service entity)
        {
            return _serviceRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<Service> entities)
        {
            return _serviceRepository.AddRangeAsync(entities);
        }

        public void Remove(Service entity)
        {
            _serviceRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Service> entities)
        {
            _serviceRepository.RemoveRange(entities);
        }

        public void Update(Service entity)
        {
            _serviceRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Service> entities)
        {
            _serviceRepository.UpdateRange(entities);
        }

        public Task<Service> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _serviceRepository.GetByIdAsync(id, asNoTracking);
        }

        public Task<List<Service>> FilterAsync(BasePagingParameters parameters)
        {
            return _serviceRepository.Filter(parameters);
        }

        public async Task<List<Service>> GetRecommendedServices(int userId)
        {
            return await _serviceRepository.GetRecommendedServices(userId);
        }

        public void Attach(Service entity)
        {
            _serviceRepository.Attach(entity);
        }
    }
}
