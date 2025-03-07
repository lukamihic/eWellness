using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;
using Microsoft.EntityFrameworkCore;
using eWellness.Core.Parameters;

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
        public override Task<List<Service>> Filter(BaseFilterParameters parameters)
        {
            return Task.FromResult(DatabaseContext.Set<Service>().AsQueryable().Include(c => c.ServiceCategory).Where(s => !s.IsDeleted && s.Name.Contains(parameters.SearchQuery ?? "")).ToList());
        }
        public async Task<List<Service>> GetRecommendedServices(int userId)
        {
            var serviceCategories = DatabaseContext.Appointments.Include(a => a.Service).ThenInclude(s => s!.ServiceCategory).Where(s => s.ClientId == userId).Select(sc => sc.Service!.ServiceCategory);
            var mostReserved = serviceCategories.GroupBy(sc => sc)
                            .OrderByDescending(g => g.Count())
                            .Select(g => new { Category = g.Key, Count = g.Count() })
                            .FirstOrDefault();

            var recommendations = DatabaseContext.Services.Where(s => s.ServiceCategoryId == mostReserved!.Category!.Id && !s.IsDeleted).ToListAsync();

            return mostReserved != null ? (await recommendations) : new List<Service>();
        }
    }
}
