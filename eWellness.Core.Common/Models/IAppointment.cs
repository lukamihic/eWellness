namespace eWellness.Core.Common.Models
{
    public interface IAppointment : IBaseModel
    {
        public int? ClientId { get; set; }

        public int? EmployeeId { get; set; }

        public int ServiceId { get; set; }

        public int? SpecialOfferId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
