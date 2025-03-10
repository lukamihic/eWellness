﻿using eWellness.Core.Parameters;
using eWellness.Core.Models;

namespace eWellness.BL.Common
{
    public interface IServiceService : IBaseService<Service, int>
    {
        Task<List<Service>> FilterAsync(BaseFilterParameters parameters);
        Task<List<Service>> GetRecommendedServices(int userId);
    }
}
