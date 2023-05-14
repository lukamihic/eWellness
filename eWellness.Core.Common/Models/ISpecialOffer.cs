namespace eWellness.Core.Common.Models
{
    public interface ISpecialOffer : IBaseModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime OfferExpirationDate { get; set; }
    }
}
