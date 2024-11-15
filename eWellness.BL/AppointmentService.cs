﻿using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class AppointmentService : IAppointmentService
    {
        protected IAppointmentRepository _appointmentRepository { get; set; }
        protected IRabbitMQProducer _rabbitMQProducer { get; set; }

        public AppointmentService(IAppointmentRepository appointmentRepository, IRabbitMQProducer rabbitMQProducer)
        {
            _appointmentRepository = appointmentRepository;
            _rabbitMQProducer = rabbitMQProducer;
        }

        public async ValueTask<int> AddAsync(Appointment entity, string mailInfo = "")
        {
            try
            {
                _rabbitMQProducer.SendEmailMessage(entity, Core.Enums.MailTypeEnum.NewAppointment);
            }
            catch (Exception e)
            {
                // Log exception or handle it appropriately
            }

            var entry = await _appointmentRepository.AddAsync(entity);

            await _appointmentRepository.SaveChangesAsync();

            return entry.Entity.Id;
        }
        public ValueTask<EntityEntry<Appointment>> AddAsync(Appointment entity)
        {
            try
            {
                _rabbitMQProducer.SendEmailMessage(entity, Core.Enums.MailTypeEnum.NewAppointment);
            }
            catch (Exception e)
            {

            }
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
