using System.Data.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using eWellness.Core;
using eWellness.Core.Common.Models;
using eWellness.DL.Common;
using eWellness.Core.Parameters;

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
            var result = DatabaseContext.Set<T>().AddAsync(entity);
            DatabaseContext.SaveChanges();

            return result;
        }

        public virtual Task AddRangeAsync(IEnumerable<T> entities)
        {
            var result = DatabaseContext.Set<T>().AddRangeAsync(entities);
            DatabaseContext.SaveChanges();

            return result;
        }

        public virtual void Remove(T entity, bool soft = true)
        {
            if(soft)
            {
                entity.IsDeleted = true;
                Update(entity);
            } else
            {
                DatabaseContext.Set<T>().Remove(entity);
                DatabaseContext.SaveChanges();
            }
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                entity.IsDeleted = true;
            }
            UpdateRange(entities);
            DatabaseContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            DatabaseContext.Set<T>().Update(entity);
            DatabaseContext.SaveChanges();
        }

        public virtual void UpdateRange(IEnumerable<T> entities)
        {
            DatabaseContext.Set<T>().UpdateRange(entities);
            DatabaseContext.SaveChanges();
        }

        public virtual Task<T> GetByIdAsync(TPrimaryKey id, bool asNoTracking = false)
        {
            var dbSet = DatabaseContext.Set<T>().AsQueryable();

            if (asNoTracking)
                dbSet = dbSet.AsNoTracking();

            return dbSet.SingleOrDefaultAsync(e => !e.IsDeleted && Equals(e.Id, id))!;
        }

        public virtual Task<List<T>> Filter(BaseFilterParameters parameters)
        {
            var dbSet = DatabaseContext.Set<T>().AsQueryable();
            if (parameters != null && parameters.DescendingSort)
                return Task.FromResult(dbSet.Where(t => !t.IsDeleted).OrderByDescending(t => t.Id).Take(parameters.PageSize).Skip(parameters.PageSize * (parameters.PageNumber - 1)).ToList());
            return Task.FromResult(dbSet.Where(t => !t.IsDeleted).OrderBy(t => t.Id).Take(parameters == null ? int.MaxValue : parameters.PageSize).Skip(parameters == null ? 0 : (parameters.PageSize * (parameters.PageNumber - 1))).ToList());
        }

        public virtual void Attach(T entity)
        {
            DatabaseContext.Set<T>().Attach(entity);
        }
    }
}
