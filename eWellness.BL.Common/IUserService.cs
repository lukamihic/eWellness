using eWellness.Core.Models;

namespace eWellness.BL.Common
{
    public interface IUserService : IBaseService<User, int>
    {
        Task<int> Login(string email, string password);
    }
}
