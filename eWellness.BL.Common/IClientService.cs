using eWellness.Core.Models;
using eWellness.Core.Parameters;

namespace eWellness.BL.Common
{
    public interface IClientService : IBaseService<Client, int>
    {
        Task<List<Client>> FilterAsync(BaseFilterParameters parameters);
    }
}
