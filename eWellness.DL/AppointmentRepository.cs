using eWellness.Core;
using eWellness.DL.Common;
using eWellness.Core.Models;
using Microsoft.EntityFrameworkCore;
using eWellness.Core.Parameters;

namespace eWellness.DL
{
    public class AppointmentRepository : BaseRepository<Appointment, int>, IAppointmentRepository
    {
        public AppointmentRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
        public override Task<Appointment> GetByIdAsync(int id, bool asNoTracking = false)
        {
            var dbSet = DatabaseContext.Set<Appointment>().AsQueryable().Include(c => c.Service).Include(c => c.Client).Include(c => c.Employee).Include(c =>c.SpecialOffer).Include(c => c.Client!.User).Include(c => c.Employee!.User);

            return dbSet.SingleOrDefaultAsync(e => !e.IsDeleted && Equals(e.Id, id))!;
        }

        public override Task<List<Appointment>> Filter(BasePagingParameters parameters)
        {
            return Task.FromResult(DatabaseContext.Set<Appointment>().AsQueryable().Include(c => c.Service).Include(c => c.Client).Include(c => c.Employee).Include(c => c.SpecialOffer).Include(c => c.Client!.User).Include(c => c.Employee!.User).Where(apt => !apt.IsDeleted).ToList());
        }
    }
}
