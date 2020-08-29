using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public User()
        {

        }

        public User(string username, string password, DateTime birthdate)
        {
            Username = username;
            Password = password;
            Birthdate = birthdate;
        }

        public User(int id, string username, string password, DateTime birthdate)
        {
            Id = id;
            Username = username;
            Password = password;
            Birthdate = birthdate;
        }
    }
}
