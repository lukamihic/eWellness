using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class EmployeeRepository : BaseRepository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
