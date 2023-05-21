using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class ActivityLog : BaseModel, IActivityLog
    {
        public string Controller { get; set; } = null!;
        public string ActionName { get; set; } = null!;
        public string LogType { get; set; } = null!;
        public string? Exception { get; set; }
        public string? Device { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
