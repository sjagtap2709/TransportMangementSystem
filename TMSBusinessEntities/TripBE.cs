using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{
    public  class TripBE
    {
        public int TripId { get; set; }

        public int? VehicleId { get; set; }

        public int? DriverId { get; set; }

        public int? RouteId { get; set; }

        public DateTime? TripDate { get; set; }

        public int? PassengerCount { get; set; }

        public bool? IsReturnTrip { get; set; }

        public bool? IsCompleted { get; set; }

        public virtual DriverBE? Driver { get; set; }

        public virtual RouteBE? Route { get; set; }

        public virtual VehicleBE? Vehicle { get; set; }

        public virtual ICollection<VerificationTripBE> VerificationTrips { get; set; } = new List<VerificationTripBE>();
    }
}
