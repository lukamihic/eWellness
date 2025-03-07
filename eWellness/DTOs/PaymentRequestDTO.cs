namespace eWellness.API.DTOs
{
    public class PaymentRequest
    {
        public decimal Amount { get; set; } // Amount in EUR, will be converted to cents
        public string Currency { get; set; } = "eur";
    }
}
