using Infrastructure.Domain.Events;
using MediatR;
using Nasab.Domain.Commands;
using Nasab.Domain.Events;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Nasab.EventHandlers
{
    public class OnNasabAddedWithMotherEventHandler : IDomainEventHandler<OnNasabAddedWithMother>
    {
        private readonly IMediator _commandBus;

        public OnNasabAddedWithMotherEventHandler(IMediator commandBus)
        {
            _commandBus = commandBus;
        }

        public async Task Handle(OnNasabAddedWithMother notification, CancellationToken cancellationToken)
        {
            var wedding = await _commandBus.Send(new AddWeddingCommand()
            {
                KabilahId = notification.Kabilah.ToString(),
                FatherId = notification.Father.ToString(),
                MotherId = notification.Mother.ToString(),
                Chidren = new List<string> { notification.Person.ToString() }
            });
        }
    }
}
