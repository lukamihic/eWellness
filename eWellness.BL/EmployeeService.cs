using eWellness.BL.Common;
using eWellness.Core.Common.Models;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class EmployeeService : IEmployeeService
    {
        protected IEmployeeRepository _employeeRepository { get; set; }

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ValueTask<EntityEntry<Employee>> AddAsync(Employee entity)
        {
            return _employeeRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<Employee> entities)
        {
            return _employeeRepository.AddRangeAsync(entities);
        }

        public void Remove(Employee entity)
        {
            _employeeRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Employee> entities)
        {
            _employeeRepository.RemoveRange(entities);
        }

        public void Update(Employee entity)
        {
            _employeeRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Employee> entities)
        {
            _employeeRepository.UpdateRange(entities);
        }

        public async Task<Employee> GetByIdAsync(int id, bool asNoTracking = false)
        {
            var employee = await _employeeRepository.GetByIdAsync(id, asNoTracking);
            if (employee.User != null)
            {
                employee.User.PasswordHash = null;
                employee.User.PasswordSalt = null;
            }
            return employee;
        }

        public Task<List<Employee>> FilterAsync(BaseFilterParameters parameters)
        {
            return _employeeRepository.Filter(parameters);
        }

        public void Attach(Employee entity)
        {
            _employeeRepository.Attach(entity);
        }
    }
}
