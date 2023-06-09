using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class ServiceCategoryService : IServiceCategoryService
    {
        protected IServiceCategoryRepository _serviceCategoryRepository { get; set; }

        public ServiceCategoryService(IServiceCategoryRepository serviceCategoryRepository)
        {
            _serviceCategoryRepository = serviceCategoryRepository;
        }

        public virtual ValueTask<EntityEntry<ServiceCategory>> AddAsync(ServiceCategory entity)
        {
            return _serviceCategoryRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<ServiceCategory> entities)
        {
            return _serviceCategoryRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(ServiceCategory entity)
        {
            _serviceCategoryRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<ServiceCategory> entities)
        {
            _serviceCategoryRepository.RemoveRange(entities);
        }

        public virtual void Update(ServiceCategory entity)
        {
            _serviceCategoryRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<ServiceCategory> entities)
        {
            _serviceCategoryRepository.UpdateRange(entities);
        }

        public virtual Task<ServiceCategory> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _serviceCategoryRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(ServiceCategory entity)
        {
            _serviceCategoryRepository.Attach(entity);
        }
    }
}
