using eWellness.Core.Models;

namespace eWellness.DL.Common
{
    public interface IServiceRepository : IBaseRepository<Service, int>
    {
        Task<List<Service>> GetRecommendedServices(int userId);
    }
}
