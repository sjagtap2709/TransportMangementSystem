using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{

    public  class RouteBE
    {
        public int RouteId { get; set; }

        public string? RouteName { get; set; }

        public string? SourceAddress { get; set; }

        public string? DestinationAddress { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<TripBE> Trips { get; set; } = new List<TripBE>();
    }
}
