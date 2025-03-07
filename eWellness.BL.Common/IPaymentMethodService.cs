using eWellness.Core.Models;
using eWellness.Core.Parameters;

namespace eWellness.BL.Common
{
    public interface IPaymentMethodService : IBaseService<PaymentMethod, int>
    {
        Task<List<PaymentMethod>> FilterAsync(BaseFilterParameters parameters);
    }
}
