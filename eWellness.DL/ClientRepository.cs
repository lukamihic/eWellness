using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class ClientRepository : BaseRepository<Client, int>, IClientRepository
    {
        public ClientRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
