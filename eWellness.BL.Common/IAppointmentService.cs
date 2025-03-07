using eWellness.Core.Models;
using eWellness.Core.Parameters;

namespace eWellness.BL.Common
{
    public interface IAppointmentService : IBaseService<Appointment, int>
    {
        Task<List<Appointment>> FilterAsync(BaseFilterParameters parameters);
        ValueTask<int> AddAsync(Appointment entity, string mailInfo);
        Task<byte[]> GetPDF();
    }
}
