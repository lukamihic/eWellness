using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class InvoiceRepository : BaseRepository<Invoice, int>, IInvoiceRepository
    {
        public InvoiceRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
