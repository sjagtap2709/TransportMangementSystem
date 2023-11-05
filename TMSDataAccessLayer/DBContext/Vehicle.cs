using System;
using System.Collections.Generic;

namespace TMSDataAccessLayer.DBContext;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string? VehicleNumber { get; set; }

    public string? VehicleName { get; set; }

    public int? VehicleType { get; set; }

    public int? Vender { get; set; }

    public int? Capacity { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();

    public virtual VehicleType? VehicleTypeNavigation { get; set; }

    public virtual Vender? VenderNavigation { get; set; }
}
