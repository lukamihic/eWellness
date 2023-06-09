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

        public virtual ValueTask<EntityEntry<ActivityLog>> AddAsync(ActivityLog entity)
        {
            return _userRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<ActivityLog> entities)
        {
            return _userRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(ActivityLog entity)
        {
            _userRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<ActivityLog> entities)
        {
            _userRepository.RemoveRange(entities);
        }

        public virtual void Update(ActivityLog entity)
        {
            _userRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<ActivityLog> entities)
        {
            _userRepository.UpdateRange(entities);
        }

        public virtual Task<ActivityLog> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _userRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(ActivityLog entity)
        {
            _userRepository.Attach(entity);
        }
    }
}
