using Infrastructure.Domain.Events;
using Nasab.Domain.Events;
using System.Threading;
using System.Threading.Tasks;

namespace Nasab.EventHandlers
{
    public class OnNasabAddedWithoutMotherEventHandler : IDomainEventHandler<OnNasabAddedWithoutMother>
    {
        public Task Handle(OnNasabAddedWithoutMother notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}