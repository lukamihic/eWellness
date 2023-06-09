using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;

namespace eWellness.DL
{
    public class AppointmentRepository : BaseRepository<Appointment, int>, IAppointmentRepository
    {
        public AppointmentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
