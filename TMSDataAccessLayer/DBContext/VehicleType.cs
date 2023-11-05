using System;
using System.Collections.Generic;

namespace TMSDataAccessLayer.DBContext;

public partial class VehicleType
{
    public int TypeId { get; set; }

    public string? TypeName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
