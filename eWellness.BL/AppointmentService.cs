using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using eWellness.DL.Common;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public Task<List<Appointment>> FilterAsync(BaseFilterParameters parameters)
        {
            return _appointmentRepository.Filter(parameters);
        }

        public async Task<byte[]> GetPDF()
        {
            var appointments = await _appointmentRepository.Filter(new BaseFilterParameters()
            {
                PageNumber = 1,
                PageSize = int.MaxValue,
                SearchQuery = ""
            });

            var appointmentsReport = appointments.Select(a => new
            {
                ClientName = a.Client?.User?.Name ?? "N/A",
                AppointmentDate = a.StartTime.ToShortDateString(),
                Price = a.TotalPrice.ToString("C", CultureInfo.InvariantCulture)
            }).ToList();

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);
                    page.Header().Text("Employee Report").FontSize(18).Bold();
                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(150);
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                        });

                        table.Header(header =>
                        {
                            header.Cell().Text("Client Name").Bold();
                            header.Cell().Text("Appointment Date").Bold();
                            header.Cell().Text("Price").Bold();
                        });

                        foreach (var ap in appointmentsReport)
                        {
                            table.Cell().Text(ap.ClientName);
                            table.Cell().Text(ap.AppointmentDate);
                            table.Cell().Text(ap.Price);
                        }
                    });
                });
            }).GeneratePdf();
        }

        public void Attach(Appointment entity)
        {
            _appointmentRepository.Attach(entity);
        }
    }
}
