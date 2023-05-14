using eWellness.Core;
using eWellness.Core.Common.Models;
using eWellness.DL.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System.Data.Common;

namespace eWellness.DL
{
    public class BaseRepository<T, TPrimaryKey> : IBaseRepository<T, TPrimaryKey> where T : class, IBaseModel
    {
        protected readonly DatabaseContext DatabaseContext;
        protected DbConnection DbConnection => DatabaseContext.Database.GetDbConnection();

        protected BaseRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public virtual ValueTask<EntityEntry<T>> AddAsync(T entity)
        {
            return DatabaseContext.Set<T>().AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<T> entities)
        {
            return DatabaseContext.Set<T>().AddRangeAsync(entities);
        }

        public virtual void Remove(T entity)
        {
            DatabaseContext.Set<T>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {

            foreach (var entity in entities)
            {
                entity.IsDeleted = true;
            }
        }

        public virtual void Update(T entity)
        {
            DatabaseContext.Set<T>().Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<T> entities)
        {
            DatabaseContext.Set<T>().UpdateRange(entities);
        }

        public virtual Task<T> GetByIdAsync(TPrimaryKey id, bool asNoTracking = false)
        {
            var dbSet = DatabaseContext.Set<T>().AsQueryable();

            if (asNoTracking)
                dbSet = dbSet.AsNoTracking();

            return dbSet.SingleOrDefaultAsync(e => !e.IsDeleted && Equals(e.Id, id))!;
        }

        public virtual void Attach(T entity)
        {
            DatabaseContext.Set<T>().Attach(entity);
        }
    }
}
