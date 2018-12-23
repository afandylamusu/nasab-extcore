using System;
using Infrastructure.Domain.Events;

namespace Nasab.Domain.Events
{
    public class OnPeopleNasabAdded : IDomainEvent
    {
        public OnPeopleNasabAdded(Guid nasabId)
        {
            PeopleNasabId = nasabId;
        }

        public Guid PeopleNasabId { get; }
    }
}
