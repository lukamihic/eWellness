﻿using eWellness.Core.Common.Models;

namespace eWellness.Core.Models
{
    public class Client : BaseModel, IClient
    {
        public DateTime LastAppointment { get; set; }
        public int? TotalAppointments { get; set; }
        public bool IsMember { get; set; }
        public DateTime MembershipExpirationDate { get; set; }

        public User? User { get; set; }
        public int? UserId { get; set; }
    }
}
