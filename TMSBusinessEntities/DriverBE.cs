using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{
    public  class DriverBE
    {
        public int DriverId { get; set; }

        public string? DriverName { get; set; }

        public string? DriverPhone { get; set; }

        public string? DriverEmail { get; set; }

        public int? Vender { get; set; }

        public string? ProfilePhoto { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<TripBE> Trips { get; set; } = new List<TripBE>();

        public virtual VenderBE? VenderNavigation { get; set; }
    }
}
