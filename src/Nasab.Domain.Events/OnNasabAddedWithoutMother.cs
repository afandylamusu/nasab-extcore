using System;
using Infrastructure.Domain.Events;

namespace Nasab.Domain.Events
{
    public class OnNasabAddedWithoutMother : IDomainEvent
    {
        public OnNasabAddedWithoutMother(Guid person, Guid father, Guid kabilah)
        {
            Person = person;
            Father = father;
            Kabilah = kabilah;
        }

        public Guid Person { get; }
        public Guid Father { get; }
        public Guid Kabilah { get; }
    }
}
