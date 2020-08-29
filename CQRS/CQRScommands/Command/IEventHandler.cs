using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CQRScommands.Command
{
    public interface IEventHandler<TCommand, TResult>
        where TCommand : Command
    {
        Task<TResult> Handle(TCommand command);
    }
}
