using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class ActivityLogRepository : BaseRepository<ActivityLog, int>, IActivityLogRepository
    {
        public ActivityLogRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
