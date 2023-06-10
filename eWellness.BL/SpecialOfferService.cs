using eWellness.BL.Common;
using eWellness.Core.Filters;
using eWellness.Core.Models;
using eWellness.DL;
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

        public ValueTask<EntityEntry<SpecialOffer>> AddAsync(SpecialOffer entity)
        {
            return _specialOfferRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<SpecialOffer> entities)
        {
            return _specialOfferRepository.AddRangeAsync(entities);
        }

        public void Remove(SpecialOffer entity)
        {
            _specialOfferRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<SpecialOffer> entities)
        {
            _specialOfferRepository.RemoveRange(entities);
        }

        public void Update(SpecialOffer entity)
        {
            _specialOfferRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<SpecialOffer> entities)
        {
            _specialOfferRepository.UpdateRange(entities);
        }

        public Task<SpecialOffer> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _specialOfferRepository.GetByIdAsync(id, asNoTracking);
        }

        public Task<List<SpecialOffer>> FilterAsync(BasePagingParameters parameters)
        {
            return _specialOfferRepository.Filter(parameters);
        }

        public void Attach(SpecialOffer entity)
        {
            _specialOfferRepository.Attach(entity);
        }
    }
}
