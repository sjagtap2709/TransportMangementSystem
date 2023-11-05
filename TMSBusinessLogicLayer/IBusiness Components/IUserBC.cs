using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSBusinessEntities;

namespace TMSBusinessLogicLayer.IBusiness_Components
{
    public interface IUserBC
    {
        IEnumerable<UserBE> GetAllUsers();
    }
}
