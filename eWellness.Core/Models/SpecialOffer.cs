using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class SpecialOffer : BaseModel, ISpecialOffer
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime OfferExpirationDate { get; set; }
    }
}
