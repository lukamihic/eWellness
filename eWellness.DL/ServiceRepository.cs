using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace eWellness.DL
{
    public class ServiceRepository : BaseRepository<Service, int>, IServiceRepository
    {
        public ServiceRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
        public override Task<Service> GetByIdAsync(int id, bool asNoTracking = false)
        {
            var dbSet = DatabaseContext.Set<Service>().AsQueryable().Include(c => c.ServiceCategory);

            return dbSet.SingleOrDefaultAsync(e => !e.IsDeleted && Equals(e.Id, id))!;
        }
    }
}
