using System;
using System.Collections.Generic;

namespace TMSDataAccessLayer.DBContext;

public partial class Trip
{
    public int TripId { get; set; }

    public int? VehicleId { get; set; }

    public int? DriverId { get; set; }

    public int? RouteId { get; set; }

    public DateTime? TripDate { get; set; }

    public int? PassengerCount { get; set; }

    public bool? IsReturnTrip { get; set; }

    public bool? IsCompleted { get; set; }

    public virtual Driver? Driver { get; set; }

    public virtual Route? Route { get; set; }

    public virtual Vehicle? Vehicle { get; set; }

    public virtual ICollection<VerificationTrip> VerificationTrips { get; set; } = new List<VerificationTrip>();
}
