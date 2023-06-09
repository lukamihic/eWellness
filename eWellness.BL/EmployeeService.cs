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

        public virtual ValueTask<EntityEntry<Employee>> AddAsync(Employee entity)
        {
            return _employeeRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<Employee> entities)
        {
            return _employeeRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(Employee entity)
        {
            _employeeRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<Employee> entities)
        {
            _employeeRepository.RemoveRange(entities);
        }

        public virtual void Update(Employee entity)
        {
            _employeeRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<Employee> entities)
        {
            _employeeRepository.UpdateRange(entities);
        }

        public virtual Task<Employee> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _employeeRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(Employee entity)
        {
            _employeeRepository.Attach(entity);
        }
    }
}
