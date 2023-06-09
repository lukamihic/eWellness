using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class PaymentMethodRepository : BaseRepository<PaymentMethod, int>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
