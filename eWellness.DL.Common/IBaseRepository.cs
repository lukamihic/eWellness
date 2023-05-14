﻿using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.DL.Common
{
    public interface IBaseRepository<T, in TPrimaryKey> where T : class
    {
        ValueTask<EntityEntry<T>> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        Task<T> GetByIdAsync(TPrimaryKey id, bool asNoTracking = false);

        void Attach(T entity);
    }
}
