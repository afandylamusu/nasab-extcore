using Infrastructure.Domain.Events;
using MediatR;
using Nasab.Domain.Commands;
using Nasab.Domain.Events;
using System;
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
                KabilahId = notification.Kabilah,
                FatherId = notification.Father,
                MotherId = notification.Mother,
                Chidren = new List<Guid> { notification.Person }
            });
        }
    }
}
