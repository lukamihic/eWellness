namespace eWellness.Core.Common.Models
{
    public interface ITip : IBaseModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }

        public int? CreatedByUserId { get; set; }
    }
}
