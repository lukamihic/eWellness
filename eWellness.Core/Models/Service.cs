using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class Service : BaseModel, IService
    {
        public string Name { get; set; } = null!; 
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; } = null!;

        public int ServiceCategoryId { get; set; }
        public IServiceCategory ServiceCategory { get; set; } = null!;
    }
}
