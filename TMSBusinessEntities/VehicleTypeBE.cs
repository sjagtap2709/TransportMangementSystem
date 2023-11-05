using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{
    public partial class VehicleTypeBE
    {
        public int TypeId { get; set; }

        public string? TypeName { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<VehicleBE> Vehicles { get; set; } = new List<VehicleBE>();
    }
}
