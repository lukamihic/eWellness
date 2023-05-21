namespace eWellness.Core.Common.Models
{
    public interface IService : IBaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; }

        public int ServiceCategoryId { get; set; }
    }
}
