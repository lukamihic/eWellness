using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class ServiceRepository : BaseRepository<Service, int>, IServiceRepository
    {
        public ServiceRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
