namespace eWellness.Core.Parameters
{
    public class BasePagingParameters
    {
        public int PageSize { get; set; } = 100;
        public int PageNumber { get; set; } = 1;
        public bool DescendingSort { get; set; } = false;
    }
}
