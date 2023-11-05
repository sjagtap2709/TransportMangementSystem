using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSDataAccessLayer.DBContext;
using TMSDataAccessLayer.IDataComponents;

namespace TMSDataAccessLayer.DataComponents
{
    public class UserDC : IUserDC
    {
        private readonly TransportMgtContext _transportMgtContext;
        public UserDC(TransportMgtContext transportMgtContext)
        {
            _transportMgtContext = transportMgtContext;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _transportMgtContext.Users.ToList(); 
        }
    }
}
