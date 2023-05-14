namespace eWellness.Core.Models
{
    public class Invoice : BaseModel
    {
        public int? AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;

        public int? ServiceId { get; set; }
        public Service Service { get; set; } = null!;
    }

}
