using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class Invoice : BaseModel, IInvoice
    {
        public int? AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;

        public int? ServiceId { get; set; }
        public Service Service { get; set; } = null!;
    }

}
