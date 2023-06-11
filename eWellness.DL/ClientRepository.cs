using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using Microsoft.EntityFrameworkCore;

namespace eWellness.DL
{
    public class ClientRepository : BaseRepository<Client, int>, IClientRepository
    {
        public ClientRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public Task<List<Client>> Filter(BaseFilterParameters parameters)
        {
            var dbSet = DatabaseContext.Set<Client>().AsQueryable().Include(c => c.User);
            if (parameters.DescendingSort)
                return Task.FromResult(dbSet.Where(t => !t.IsDeleted && t.User!.Name.ToLower().Contains(parameters.SearchQuery)).OrderByDescending(t => t.Id).Take(parameters.PageSize).Skip(parameters.PageSize * (parameters.PageNumber - 1)).ToList());
            return Task.FromResult(dbSet.Where(t => !t.IsDeleted).OrderBy(t => t.Id).Take(parameters.PageSize).Skip(parameters.PageSize * (parameters.PageNumber - 1)).ToList());
        }

        public override Task<Client> GetByIdAsync(int id, bool asNoTracking = false)
        {
            var dbSet = DatabaseContext.Set<Client>().AsQueryable().Include(c => c.User);

            return dbSet.SingleOrDefaultAsync(e => !e.IsDeleted && Equals(e.Id, id))!;
        }
    }
}
