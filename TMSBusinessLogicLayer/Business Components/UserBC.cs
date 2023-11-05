using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSBusinessEntities;
using TMSBusinessLogicLayer.IBusiness_Components;
using TMSBusinessLogicLayer.Mapper;
using TMSDataAccessLayer.IDataComponents;

namespace TMSBusinessLogicLayer.Business_Components
{
    public class UserBC : IUserBC
    {
        private readonly IUserDC _userDC;
        public UserBC(IUserDC userDC)
        {
            _userDC = userDC;
        }
        public IEnumerable<UserBE> GetAllUsers()
        {

            return _userDC.GetAllUsers().Map();
        }
    }
}
