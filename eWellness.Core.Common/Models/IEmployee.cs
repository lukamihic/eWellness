namespace eWellness.Core.Common.Models
{
    public interface IEmployee : IBaseModel
    {
        public decimal Salary { get; set; }
        public string Position { get; set; }

        public int? UserId { get; set; }
    }
}
