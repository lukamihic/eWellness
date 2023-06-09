using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class SpecialOfferService : ISpecialOfferService
    {
        protected ISpecialOfferRepository _specialOfferRepository { get; set; }

        public SpecialOfferService(ISpecialOfferRepository specialOfferRepository)
        {
            _specialOfferRepository = specialOfferRepository;
        }

        public virtual ValueTask<EntityEntry<SpecialOffer>> AddAsync(SpecialOffer entity)
        {
            return _specialOfferRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<SpecialOffer> entities)
        {
            return _specialOfferRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(SpecialOffer entity)
        {
            _specialOfferRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<SpecialOffer> entities)
        {
            _specialOfferRepository.RemoveRange(entities);
        }

        public virtual void Update(SpecialOffer entity)
        {
            _specialOfferRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<SpecialOffer> entities)
        {
            _specialOfferRepository.UpdateRange(entities);
        }

        public virtual Task<SpecialOffer> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _specialOfferRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(SpecialOffer entity)
        {
            _specialOfferRepository.Attach(entity);
        }
    }
}
