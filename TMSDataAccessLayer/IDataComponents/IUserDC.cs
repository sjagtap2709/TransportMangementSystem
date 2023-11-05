using Castle.Core.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSDataAccessLayer.DBContext;

namespace TMSDataAccessLayer.IDataComponents
{
    public interface IUserDC
    {
        IEnumerable<User> GetAllUsers ();
    }
}
