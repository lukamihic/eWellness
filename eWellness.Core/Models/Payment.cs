using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class Payment : BaseModel, IPayment
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid TransactionId { get; set; } = new Guid();
        public decimal Fees { get; set; }

        public int? PaymentMethodId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }

        public int? AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
    }
}
