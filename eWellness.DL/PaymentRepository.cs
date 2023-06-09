using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class PaymentRepository : BaseRepository<Payment, int>, IPaymentRepository
    {
        public PaymentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
