using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

    }
}
