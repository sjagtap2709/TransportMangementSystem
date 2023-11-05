using System;
using System.Collections.Generic;

namespace TMSDataAccessLayer.DBContext;

public partial class Route
{
    public int RouteId { get; set; }

    public string? RouteName { get; set; }

    public string? SourceAddress { get; set; }

    public string? DestinationAddress { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
