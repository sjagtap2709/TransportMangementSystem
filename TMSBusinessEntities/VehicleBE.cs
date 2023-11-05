using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{

    public partial class VehicleBE
    {
        public int VehicleId { get; set; }

        public string? VehicleNumber { get; set; }

        public string? VehicleName { get; set; }

        public int? VehicleType { get; set; }

        public int? Vender { get; set; }

        public int? Capacity { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<TripBE> Trips { get; set; } = new List<TripBE>();

        public virtual VehicleTypeBE? VehicleTypeNavigation { get; set; }

        public virtual VenderBE? VenderNavigation { get; set; }
    }
}
