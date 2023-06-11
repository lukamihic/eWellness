using eWellness.Core.Models;
using eWellness.Core.Parameters;

namespace eWellness.DL.Common
{
    public interface IClientRepository : IBaseRepository<Client, int>
    {
        Task<List<Client>> Filter(BaseFilterParameters parameters);
    }
}
