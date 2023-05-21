using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class Tip : BaseModel, ITip
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        
        public int? CreatedByUserId { get; set; }
        public User? CreatedByUser { get; set; }
    }
}
