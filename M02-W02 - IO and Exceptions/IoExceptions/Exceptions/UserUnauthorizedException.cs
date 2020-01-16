using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class UserUnauthorizedException : Exception
    {
        public string User { get; private set; }

        public UserUnauthorizedException()
        {
        }

        public UserUnauthorizedException(string user) 
            : base("The user is not authorized to perform this action")
        {
            User = user;
        }

        public override string ToString()
        {
            string description = GetType().FullName + ": " + Message;
            if (User != null)
            {
                description = description + "User: " + User;
            }
            return description;
        }
    }
}
