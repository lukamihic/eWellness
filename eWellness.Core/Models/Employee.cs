using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class Employee : BaseModel, IEmployee
    {
        public decimal Salary { get; set; }
        public string Position { get; set; } = null!;

        public int? UserId { get; set; }
        public User? User { get; set; }
    }

}
