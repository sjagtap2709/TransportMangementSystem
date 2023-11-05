using System;
using System.Collections.Generic;

namespace TMSDataAccessLayer.DBContext;

public partial class VerificationTrip
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

    public virtual Trip? Trip { get; set; }

    public virtual User? VerifiedByNavigation { get; set; }
}
