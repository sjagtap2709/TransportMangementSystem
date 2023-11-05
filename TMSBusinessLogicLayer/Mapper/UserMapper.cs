using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSBusinessEntities;
using TMSDataAccessLayer.DBContext;

namespace TMSBusinessLogicLayer.Mapper
{
    public static class UserMapper
    {
        public static UserBE Map(this User model)
        {
            UserBE userBE;
            if (model != null)
            {
                userBE = new UserBE()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    RoleId = model.RoleId,
                    Password = model.Password,
                    PhoneNumber = model.PhoneNumber,
                };

            }
            else
            {
                userBE = new UserBE();
            }
            return userBE;
        }
        public static User Map(this UserBE model)
        {
            User userBE;
            if (model != null)
            {
                userBE = new User()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    RoleId = model.RoleId,
                    Password = model.Password,
                    PhoneNumber = model.PhoneNumber,
                };

            }
            else
            {
                userBE = new User();
            }
            return userBE;
        }

        public static IEnumerable<User> Map(this IEnumerable<UserBE> model)
        {
            List<User> users = new List<User>();
            foreach (var item in model)
            {
                users.Add(Map(item));
            }
            return users;
        }
        public static IEnumerable<UserBE> Map(this IEnumerable<User> model)
        {
            List<UserBE> users = new List<UserBE>();
            foreach (var item in model)
            {
                users.Add(Map(item));
            }
            return users;
        }
    }
}
