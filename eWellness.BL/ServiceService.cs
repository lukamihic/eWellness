using eWellness.BL.Common;
using eWellness.Core.Models;
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

        public virtual ValueTask<EntityEntry<Service>> AddAsync(Service entity)
        {
            return _serviceRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<Service> entities)
        {
            return _serviceRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(Service entity)
        {
            _serviceRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<Service> entities)
        {
            _serviceRepository.RemoveRange(entities);
        }

        public virtual void Update(Service entity)
        {
            _serviceRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<Service> entities)
        {
            _serviceRepository.UpdateRange(entities);
        }

        public virtual Task<Service> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _serviceRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(Service entity)
        {
            _serviceRepository.Attach(entity);
        }
    }
}
