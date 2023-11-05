using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{

    public partial class VenderBE
    {
        public int VenderId { get; set; }

        public string? VenderName { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<DriverBE> Drivers { get; set; } = new List<DriverBE>();

        public virtual ICollection<VehicleBE> Vehicles { get; set; } = new List<VehicleBE>();
    }
}
