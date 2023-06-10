using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class PaymentService : IPaymentService
    {
        protected IPaymentRepository _paymentRepository { get; set; }

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public ValueTask<EntityEntry<Payment>> AddAsync(Payment entity)
        {
            return _paymentRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<Payment> entities)
        {
            return _paymentRepository.AddRangeAsync(entities);
        }

        public void Remove(Payment entity)
        {
            _paymentRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Payment> entities)
        {
            _paymentRepository.RemoveRange(entities);
        }

        public void Update(Payment entity)
        {
            _paymentRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Payment> entities)
        {
            _paymentRepository.UpdateRange(entities);
        }

        public Task<Payment> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _paymentRepository.GetByIdAsync(id, asNoTracking);
        }

        public void Attach(Payment entity)
        {
            _paymentRepository.Attach(entity);
        }
    }
}
