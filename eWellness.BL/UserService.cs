using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class UserService : IUserService
    {
        protected IUserRepository _userRepository { get; set; }

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ValueTask<EntityEntry<User>> AddAsync(User entity)
        {
            return _userRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<User> entities)
        {
            return _userRepository.AddRangeAsync(entities);
        }

        public void Remove(User entity)
        {
            _userRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<User> entities)
        {
            _userRepository.RemoveRange(entities);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<User> entities)
        {
            _userRepository.UpdateRange(entities);
        }

        public Task<User> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _userRepository.GetByIdAsync(id, asNoTracking);
        }

        public void Attach(User entity)
        {
            _userRepository.Attach(entity);
        }
    }
}
