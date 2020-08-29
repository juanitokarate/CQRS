using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CQRSmediatrcommands.Command
{
    public class UpdateUsernameCommand : IRequest<UpdateUsernameResponse>
    {
    }
}
