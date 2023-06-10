using eWellness.BL.Common;
using eWellness.Core.Filters;
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

        public ValueTask<EntityEntry<Tip>> AddAsync(Tip entity)
        {
            return _tipRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<Tip> entities)
        {
            return _tipRepository.AddRangeAsync(entities);
        }

        public void Remove(Tip entity)
        {
            _tipRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Tip> entities)
        {
            _tipRepository.RemoveRange(entities);
        }

        public void Update(Tip entity)
        {
            _tipRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Tip> entities)
        {
            _tipRepository.UpdateRange(entities);
        }

        public Task<Tip> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _tipRepository.GetByIdAsync(id, asNoTracking);
        }

        public Task<List<Tip>> FilterAsync(BasePagingParameters parameters)
        {
            return _tipRepository.Filter(parameters);
        }

        public void Attach(Tip entity)
        {
            _tipRepository.Attach(entity);
        }
    }
}
