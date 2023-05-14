namespace eWellness.Core.Common.Models
{
    public interface IServiceCategory : IBaseModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
