using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CQRScommands.Command
{
    public class CreateNewUserCommand : Command 
    {
        public CreateNewUserCommand(string username, string password, DateTime birthdate)
        {
            Username = username;
            Password = password;
            Birthdate = birthdate;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
