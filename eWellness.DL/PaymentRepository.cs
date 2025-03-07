using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using Microsoft.EntityFrameworkCore;

namespace eWellness.DL
{
    public class PaymentRepository : BaseRepository<Payment, int>, IPaymentRepository
    {
        public PaymentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
        public override Task<List<Payment>> Filter(BaseFilterParameters parameters)
        {
            return Task.FromResult(DatabaseContext.Set<Payment>().AsQueryable().Include(c => c.Appointment).Include(c => c.Appointment!.Client).Include(c => c.Appointment!.Client!.User).Include(c => c.PaymentMethod).Where(pmt => !pmt.IsDeleted).ToList());
        }
    }
}
