using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class ServiceCategoryRepository : BaseRepository<ServiceCategory, int>, IServiceCategoryRepository
    {
        public ServiceCategoryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
