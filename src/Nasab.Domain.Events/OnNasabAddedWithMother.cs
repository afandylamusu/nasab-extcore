using Infrastructure.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nasab.Domain.Events
{
    public class OnNasabAddedWithMother : IDomainEvent
    {
        public OnNasabAddedWithMother(Guid person, Guid father, Guid mother, Guid kabilah)
        {
            Person = person;
            Father = father;
            Mother = mother;
            Kabilah = kabilah;
        }

        public Guid Person { get; }
        public Guid Father { get; }
        public Guid Mother { get; }
        public Guid Kabilah { get; }
    }
}
