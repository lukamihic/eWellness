﻿namespace eWellness.Core.Parameters
{
    public abstract class BasePagingParameters
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
        public bool DescendingSort { get; set; } = true;
    }
}
