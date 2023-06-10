using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class ActivityLogService : IActivityLogService
    {
        protected IActivityLogRepository _userRepository { get; set; }

        public ActivityLogService(IActivityLogRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ValueTask<EntityEntry<ActivityLog>> AddAsync(ActivityLog entity)
        {
            return _userRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<ActivityLog> entities)
        {
            return _userRepository.AddRangeAsync(entities);
        }

        public void Remove(ActivityLog entity)
        {
            _userRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<ActivityLog> entities)
        {
            _userRepository.RemoveRange(entities);
        }

        public void Update(ActivityLog entity)
        {
            _userRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<ActivityLog> entities)
        {
            _userRepository.UpdateRange(entities);
        }

        public Task<ActivityLog> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _userRepository.GetByIdAsync(id, asNoTracking);
        }

        public void Attach(ActivityLog entity)
        {
            _userRepository.Attach(entity);
        }
    }
}
