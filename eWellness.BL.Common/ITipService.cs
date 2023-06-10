using eWellness.Core.Filters;
using eWellness.Core.Models;

namespace eWellness.BL.Common
{
    public interface ITipService : IBaseService<Tip, int>
    {
        Task<List<Tip>> FilterAsync(BasePagingParameters parameters);
    }
}
