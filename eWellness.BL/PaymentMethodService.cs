using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using eWellness.DL;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class PaymentMethodService : IPaymentMethodService
    {
        protected IPaymentMethodRepository _paymentMethodRepository { get; set; }

        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
        }

        public ValueTask<EntityEntry<PaymentMethod>> AddAsync(PaymentMethod entity)
        {
            return _paymentMethodRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<PaymentMethod> entities)
        {
            return _paymentMethodRepository.AddRangeAsync(entities);
        }

        public void Remove(PaymentMethod entity)
        {
            _paymentMethodRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<PaymentMethod> entities)
        {
            _paymentMethodRepository.RemoveRange(entities);
        }

        public void Update(PaymentMethod entity)
        {
            _paymentMethodRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<PaymentMethod> entities)
        {
            _paymentMethodRepository.UpdateRange(entities);
        }

        public Task<PaymentMethod> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _paymentMethodRepository.GetByIdAsync(id, asNoTracking);
        }

        public Task<List<PaymentMethod>> FilterAsync(BasePagingParameters parameters)
        {
            return _paymentMethodRepository.Filter(parameters);
        }

        public void Attach(PaymentMethod entity)
        {
            _paymentMethodRepository.Attach(entity);
        }
    }
}
