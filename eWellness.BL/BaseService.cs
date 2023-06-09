using eWellness.BL.Common;
using eWellness.Core.Common.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class BaseService<T, TPrimaryKey> : IBaseService<T, TPrimaryKey> where T : class, IBaseModel
    {
        IBaseRepository<T, TPrimaryKey> _baseRepository;
        protected BaseService(IBaseRepository<T, TPrimaryKey> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public virtual ValueTask<EntityEntry<T>> AddAsync(T entity)
        {
            return _baseRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<T> entities)
        {
            return _baseRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(T entity)
        {
            _baseRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _baseRepository.RemoveRange(entities);
        }

        public virtual void Update(T entity)
        {
            _baseRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<T> entities)
        {
            _baseRepository.UpdateRange(entities);
        }

        public virtual Task<T> GetByIdAsync(TPrimaryKey id, bool asNoTracking = false)
        {
            return _baseRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(T entity)
        {
            _baseRepository.Attach(entity);
        }
    }
}
