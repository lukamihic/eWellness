using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class SpecialOfferRepository : BaseRepository<SpecialOffer, int>, ISpecialOfferRepository
    {
        public SpecialOfferRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
