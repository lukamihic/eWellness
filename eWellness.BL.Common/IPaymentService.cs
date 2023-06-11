using eWellness.Core.Models;
using eWellness.Core.Parameters;

namespace eWellness.BL.Common
{
    public interface IPaymentService : IBaseService<Payment, int>
    {
        Task<List<Payment>> FilterAsync(BasePagingParameters parameters);
    }
}
