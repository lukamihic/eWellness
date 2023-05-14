using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class Appointment : BaseModel, IAppointment
    {
        public int? ClientId { get; set; }
        public IClient? Client { get; set; }

        public int? EmployeeId { get; set; }
        public IEmployee? Employee { get; set; }

        public int ServiceId { get; set; }
        public IService Service { get; set; } = null!;

        public int? SpecialOfferId { get; set; }
        public ISpecialOffer? SpecialOffer { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; } = null!;
        public string Status { get; set; } = null!;
        public decimal TotalPrice { get; set; }
    }
}
