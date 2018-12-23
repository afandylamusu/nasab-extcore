using Infrastructure.Domain.Commands;
using Nasab.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Nasab.Domain.Commands
{
    public class AddWeddingCommandHandler : ICommandHandler<AddWeddingCommand, Wedding>
    {
        public Task<Wedding> Handle(AddWeddingCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
