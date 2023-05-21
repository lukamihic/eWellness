using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        public UserRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
