using eWellness.Core.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace eWellness.Core.Models
{
    public class Appointment : BaseModel, IAppointment
    {
        public int? ClientId { get; set; }
        public Client? Client { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public int ServiceId { get; set; }
        public Service? Service { get; set; } = null!;

        public int? SpecialOfferId { get; set; }
        public SpecialOffer? SpecialOffer { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; } = null!;
        public string Status { get; set; } = null!;
        public decimal TotalPrice { get; set; }

        [NotMapped]
        public string? Name { get; set; }
    }
}
