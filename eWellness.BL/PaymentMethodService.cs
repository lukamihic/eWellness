using eWellness.BL.Common;
using eWellness.Core.Models;
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

        public virtual ValueTask<EntityEntry<PaymentMethod>> AddAsync(PaymentMethod entity)
        {
            return _paymentMethodRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<PaymentMethod> entities)
        {
            return _paymentMethodRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(PaymentMethod entity)
        {
            _paymentMethodRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<PaymentMethod> entities)
        {
            _paymentMethodRepository.RemoveRange(entities);
        }

        public virtual void Update(PaymentMethod entity)
        {
            _paymentMethodRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<PaymentMethod> entities)
        {
            _paymentMethodRepository.UpdateRange(entities);
        }

        public virtual Task<PaymentMethod> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _paymentMethodRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(PaymentMethod entity)
        {
            _paymentMethodRepository.Attach(entity);
        }
    }
}
