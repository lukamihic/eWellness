using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using Microsoft.EntityFrameworkCore;

namespace eWellness.DL
{
    public class EmployeeRepository : BaseRepository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public Task<List<Employee>> Filter(BaseFilterParameters parameters)
        {
            var dbSet = DatabaseContext.Set<Employee>().AsQueryable().Include(c => c.User);
            if (parameters.DescendingSort)
                return Task.FromResult(dbSet.Where(t => !t.IsDeleted && t.User!.Name.ToLower().Contains(parameters.SearchQuery)).OrderByDescending(t => t.Id).Take(parameters.PageSize).Skip(parameters.PageSize * (parameters.PageNumber - 1)).ToList());
            return Task.FromResult(dbSet.Where(t => !t.IsDeleted).OrderBy(t => t.Id).Take(parameters.PageSize).Skip(parameters.PageSize * (parameters.PageNumber - 1)).ToList());
        }

        
    }
}
