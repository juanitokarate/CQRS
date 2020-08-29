using CQRS.CQRScommands.Command;
using CQRS.CQRScommands.Responses;
using CQRS.Database;
using CQRS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CQRScommands
{
    public class CreateNewUserEventHandler : IEventHandler<CreateNewUserCommand, CreateNewUserResult>
    {
        private readonly DBContext db;

        public CreateNewUserEventHandler(DBContext db)
        {
            this.db = db;
        }

        public async Task<CreateNewUserResult> Handle(CreateNewUserCommand command)
        {

            var user = new User(command.Username, command.Password, command.Birthdate);
            var response = new CreateNewUserResult(user.Id, user.Username);

            return response;
        }
    }
}