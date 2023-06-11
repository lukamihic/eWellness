using eWellness.BL.Common;
using eWellness.Core.Parameters;
using eWellness.Core.Models;
using eWellness.DL;
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

        public ValueTask<EntityEntry<ServiceCategory>> AddAsync(ServiceCategory entity)
        {
            return _serviceCategoryRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<ServiceCategory> entities)
        {
            return _serviceCategoryRepository.AddRangeAsync(entities);
        }

        public void Remove(ServiceCategory entity)
        {
            _serviceCategoryRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<ServiceCategory> entities)
        {
            _serviceCategoryRepository.RemoveRange(entities);
        }

        public void Update(ServiceCategory entity)
        {
            _serviceCategoryRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<ServiceCategory> entities)
        {
            _serviceCategoryRepository.UpdateRange(entities);
        }

        public Task<ServiceCategory> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _serviceCategoryRepository.GetByIdAsync(id, asNoTracking);
        }

        public Task<List<ServiceCategory>> FilterAsync(BasePagingParameters parameters)
        {
            return _serviceCategoryRepository.Filter(parameters);
        }

        public void Attach(ServiceCategory entity)
        {
            _serviceCategoryRepository.Attach(entity);
        }
    }
}
