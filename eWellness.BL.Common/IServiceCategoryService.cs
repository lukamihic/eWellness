﻿using eWellness.Core.Filters;
using eWellness.Core.Models;

namespace eWellness.BL.Common
{
    public interface IServiceCategoryService : IBaseService<ServiceCategory, int>
    {
        Task<List<ServiceCategory>> FilterAsync(BasePagingParameters parameters);
    }
}
