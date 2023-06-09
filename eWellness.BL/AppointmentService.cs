using eWellness.BL.Common;
using eWellness.Core.Models;
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

        public virtual ValueTask<EntityEntry<Appointment>> AddAsync(Appointment entity)
        {
            return _appointmentRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<Appointment> entities)
        {
            return _appointmentRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(Appointment entity)
        {
            _appointmentRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<Appointment> entities)
        {
            _appointmentRepository.RemoveRange(entities);
        }

        public virtual void Update(Appointment entity)
        {
            _appointmentRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<Appointment> entities)
        {
            _appointmentRepository.UpdateRange(entities);
        }

        public virtual Task<Appointment> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _appointmentRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(Appointment entity)
        {
            _appointmentRepository.Attach(entity);
        }
    }
}
