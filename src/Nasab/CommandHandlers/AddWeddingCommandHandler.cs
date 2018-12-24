using Infrastructure.Domain.Commands;
using Nasab.Domain.Entities;
using Nasab.Domain.ValueObjects;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Nasab.Domain.Commands
{
    public class AddWeddingCommandHandler : ICommandHandler<AddWeddingCommand, Wedding>
    {
        public Task<Wedding> Handle(AddWeddingCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Wedding(Guid.NewGuid(), new PeopleId(request.FatherId), request.KabilahId, new PeopleId(request.MotherId)));
        }
    }
}
