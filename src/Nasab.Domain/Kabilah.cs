using Infrastructure.Domain;
using Nasab.Domain.Entities;
using Nasab.Domain.ReadModels;
using Nasab.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Nasab.Domain
{
    public class Kabilah : AggregateRoot<Kabilah, KabilahReadModel>
    {
        public Kabilah(Guid identity) : base(identity)
        {
            Weddings = new List<Wedding>().AsReadOnly();
        }

        public Kabilah(KabilahReadModel readModel) : base(readModel)
        {
        }

        public IReadOnlyCollection<Wedding> Weddings { get; }

        protected override Kabilah GetEntity()
        {
            return this;
        }

        public void AddWedding(Guid father, Guid mother, Guid person)
        {
            var wedding = new Wedding(Guid.NewGuid(), new PeopleId(father.ToString()), Identity, new PeopleId(mother.ToString()));

            wedding.AddChild(new PeopleId(person.ToString()));
        }
    }
}
