using eWellness.Core.Parameters;
using eWellness.Core.Models;

namespace eWellness.BL.Common
{
    public interface ISpecialOfferService : IBaseService<SpecialOffer, int>
    {
        Task<List<SpecialOffer>> FilterAsync(BasePagingParameters parameters);
    }
}
