namespace eWellness.Core.Common.Models
{
    public interface IPayment : IBaseModel
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string TransactionId { get; set; }
        public decimal Fees { get; set; }

        public int? PaymentMethodId { get; set; }

        public int? AppointmentId { get; set; }
    }
}
