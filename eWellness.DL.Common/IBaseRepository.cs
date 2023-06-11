using eWellness.Core.Parameters;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.DL.Common
{
    public interface IBaseRepository<T, in TPrimaryKey> where T : class
    {
        ValueTask<EntityEntry<T>> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        void Remove(T entity, bool soft = true);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        Task<T> GetByIdAsync(TPrimaryKey id, bool asNoTracking = false);
        Task<List<T>> Filter(BasePagingParameters parameters);


        void Attach(T entity);
    }
}
