using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{

    public partial class VerificationTripBE
    {
        public int VerificationTripId { get; set; }

        public int? TripId { get; set; }

        public bool? IsValidDriver { get; set; }

        public bool? IsValidPassangerCount { get; set; }

        public bool? IsValidVehicle { get; set; }

        public string? VehicleNumber { get; set; }

        public int? PassangerCount { get; set; }

        public string? DriverName { get; set; }

        public TimeSpan? ValidateTime { get; set; }

        public int? VerifiedBy { get; set; }

        public virtual TripBE? Trip { get; set; }

        public virtual UserBE? VerifiedByNavigation { get; set; }
    }
}
