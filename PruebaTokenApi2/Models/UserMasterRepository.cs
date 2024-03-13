using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTokenApi2.Models
{
    public class UserMasterRepository : IDisposable
    {
        // SECURITY_DBEntities it is your context class
        //SECURITY_DBEntities context = new SECURITY_DBEntities();
        //This method is used to check and validate the user credentials


        readonly List<UserMaster> context = new List<UserMaster>()
        {
            new UserMaster()
            {
                UserID = 101,
                UserName = "lvasquez",
                UserPassword = "1234",
                UserRoles = "Admin",
                UserEmailID = "lvasquez@prides.net"
            },
            new UserMaster()
            {
                UserID = 102,
                UserName = "jsandoval",
                UserPassword = "1234",
                UserRoles = "SuperAdmin",
                UserEmailID = "jsandoval@prides.net"
            },
        };

		public void Dispose()
		{
		}

		public UserMaster ValidateUser(string username, string password)
        {
            return context.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.UserPassword == password);
        }
        /*public void Dispose()
        {
            context.Dispose();
        }*/
    }
}