using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class TipService : ITipService
    {
        protected ITipRepository _tipRepository { get; set; }

        public TipService(ITipRepository tipRepository)
        {
            _tipRepository = tipRepository;
        }

        public virtual ValueTask<EntityEntry<Tip>> AddAsync(Tip entity)
        {
            return _tipRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<Tip> entities)
        {
            return _tipRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(Tip entity)
        {
            _tipRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<Tip> entities)
        {
            _tipRepository.RemoveRange(entities);
        }

        public virtual void Update(Tip entity)
        {
            _tipRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<Tip> entities)
        {
            _tipRepository.UpdateRange(entities);
        }

        public virtual Task<Tip> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _tipRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(Tip entity)
        {
            _tipRepository.Attach(entity);
        }
    }
}
