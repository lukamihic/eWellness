using eWellness.Core.Models;
using eWellness.Core.Parameters;

namespace eWellness.BL.Common
{
    public interface IEmployeeService : IBaseService<Employee, int>
    {
        Task<List<Employee>> FilterAsync(BaseFilterParameters parameters);
    }
}
