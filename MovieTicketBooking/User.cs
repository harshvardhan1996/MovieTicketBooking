using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public User(string UserName, string Password, string UserType)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.UserType = UserType;
        }
    }
}
