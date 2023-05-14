namespace eWellness.Core.Common.Models
{
    public interface IClient : IBaseModel
    {
        public DateTime LastAppointment { get; set; }
        public int? TotalAppointments { get; set; }
        public bool IsMember { get; set; }
        public DateTime MembershipExpirationDate { get; set; }

        public IUser? User { get; set; }
        public int? UserId { get; set; }
    }
}
