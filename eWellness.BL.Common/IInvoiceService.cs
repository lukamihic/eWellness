using eWellness.Core.Models;
using eWellness.Core.Parameters;

namespace eWellness.BL.Common
{
    public interface IInvoiceService : IBaseService<Invoice, int>
    {
        Task<List<Invoice>> FilterAsync(BasePagingParameters parameters);
    }
}
