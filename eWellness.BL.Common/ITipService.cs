using eWellness.Core.Parameters;
using eWellness.Core.Models;

namespace eWellness.BL.Common
{
    public interface ITipService : IBaseService<Tip, int>
    {
        Task<List<Tip>> FilterAsync(BasePagingParameters parameters);
    }
}
