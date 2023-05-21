using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class PaymentMethod : BaseModel, IPaymentMethod
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
