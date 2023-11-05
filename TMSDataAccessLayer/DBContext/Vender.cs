using System;
using System.Collections.Generic;

namespace TMSDataAccessLayer.DBContext;

public partial class Vender
{
    public int VenderId { get; set; }

    public string? VenderName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
