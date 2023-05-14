namespace eWellness.Core.Common.Models
{
    public interface IActivityLog : IBaseModel
    {
        public string Controller { get; set; }
        public string ActionName { get; set; }
        public string LogType { get; set; }
        public string? Exception { get; set; }
        public string? Device { get; set; }

        public int? UserId { get; set; }
        public IUser? User { get; set; }
    }
}
