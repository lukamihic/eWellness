namespace eWellness.Core.Filters
{
    public class BasePagingParameters
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
        public bool DescendingSort { get; set; } = true;
    }
}
