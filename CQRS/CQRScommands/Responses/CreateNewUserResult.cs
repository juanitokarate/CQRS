using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CQRScommands.Responses
{
    public class CreateNewUserResult
    {
        public CreateNewUserResult(int id, string username)
        {
            Id = id;
            Username = username;
        }

        public int Id { get; set; }
        public string Username { get; set; }
    }
}
