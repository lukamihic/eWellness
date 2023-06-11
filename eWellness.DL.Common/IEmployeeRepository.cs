using eWellness.Core.Models;
using eWellness.Core.Parameters;

namespace eWellness.DL.Common
{
    public interface IEmployeeRepository : IBaseRepository<Employee, int>
    {
        Task<List<Employee>> Filter(BaseFilterParameters parameters);
    }
}
