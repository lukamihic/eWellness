using eWellness.BL.Common;
using eWellness.Core.Models;
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

        public Task<Employee> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _employeeRepository.GetByIdAsync(id, asNoTracking);
        }

        public void Attach(Employee entity)
        {
            _employeeRepository.Attach(entity);
        }
    }
}
