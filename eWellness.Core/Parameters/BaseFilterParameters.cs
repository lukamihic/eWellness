namespace eWellness.Core.Parameters
{
    public class BaseFilterParameters : BasePagingParameters
    {
        public string SearchQuery { get; set; } = string.Empty;
    }
}
