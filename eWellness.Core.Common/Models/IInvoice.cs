namespace eWellness.Core.Common.Models
{
    public interface IInvoice : IBaseModel
    {
        public int? AppointmentId { get; set; }
        public int? ServiceId { get; set; }
    }
}
