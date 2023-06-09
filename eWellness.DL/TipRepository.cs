using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class TipRepository : BaseRepository<Tip, int>, ITipRepository
    {
        public TipRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
