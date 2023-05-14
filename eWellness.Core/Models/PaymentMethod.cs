namespace eWellness.Core.Models
{
    public class PaymentMethod : BaseModel
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
