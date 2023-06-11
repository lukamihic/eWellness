using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using eWellness.DL;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class AppointmentService : IAppointmentService
    {
        protected IAppointmentRepository _appointmentRepository { get; set; }

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public ValueTask<EntityEntry<Appointment>> AddAsync(Appointment entity)
        {
            return _appointmentRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<Appointment> entities)
        {
            return _appointmentRepository.AddRangeAsync(entities);
        }

        public void Remove(Appointment entity)
        {
            _appointmentRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Appointment> entities)
        {
            _appointmentRepository.RemoveRange(entities);
        }

        public void Update(Appointment entity)
        {
            _appointmentRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Appointment> entities)
        {
            _appointmentRepository.UpdateRange(entities);
        }

        public Task<Appointment> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _appointmentRepository.GetByIdAsync(id, asNoTracking);
        }

        public Task<List<Appointment>> FilterAsync(BasePagingParameters parameters)
        {
            return _appointmentRepository.Filter(parameters);
        }

        public void Attach(Appointment entity)
        {
            _appointmentRepository.Attach(entity);
        }
    }
}
