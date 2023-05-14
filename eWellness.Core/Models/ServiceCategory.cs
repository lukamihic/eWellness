using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class ServiceCategory : BaseModel, IServiceCategory
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
