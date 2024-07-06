using eWellness.Core.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace eWellness.Core.Models
{
    public class User : BaseModel, IUser
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactPhone { get; set; }
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }

        [NotMapped]
        public string PasswordInput { get; set; }
    }

}
