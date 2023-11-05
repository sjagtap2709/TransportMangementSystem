using System;
using System.Collections.Generic;

namespace TMSDataAccessLayer.DBContext;

public partial class Driver
{
    public int DriverId { get; set; }

    public string? DriverName { get; set; }

    public string? DriverPhone { get; set; }

    public string? DriverEmail { get; set; }

    public int? Vender { get; set; }

    public string? ProfilePhoto { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();

    public virtual Vender? VenderNavigation { get; set; }
}
