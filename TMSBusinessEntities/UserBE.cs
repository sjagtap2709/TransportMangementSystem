using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{

    public partial class UserBE
    {
        public int UserId { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? PhoneNumber { get; set; }

        public int? RoleId { get; set; }

        public virtual RoleBE? Role { get; set; }

        public virtual ICollection<VerificationTripBE> VerificationTrips { get; set; } = new List<VerificationTripBE>();
    }
}
