using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }

        public User(string username, string surname, string email, string password, int roleID)
        {
            Username = username;
            Surname = surname;
            Email = email;
            Password = password;
            RoleID = roleID;
        }
    }
}
