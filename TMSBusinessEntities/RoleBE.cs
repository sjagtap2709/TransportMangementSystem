using System;
using System.Collections.Generic;

namespace TMSBusinessEntities
{

    public  class RoleBE
    {
        public int RoleId { get; set; }

        public string? RoleName { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<UserBE> Users { get; set; } = new List<UserBE>();
    }
}
