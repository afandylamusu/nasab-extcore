using Infrastructure.Domain.Events;
using Nasab.Domain.Events;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Nasab.EventHandlers
{
    public class OnPeopleNasabAddedEventHandler : IDomainEventHandler<OnPeopleNasabAdded>
    {
        public Task Handle(OnPeopleNasabAdded notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
