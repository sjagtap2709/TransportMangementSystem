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
