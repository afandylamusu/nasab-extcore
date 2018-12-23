using Infrastructure.Domain;
using Nasab.Domain.Events;
using Nasab.Domain.ReadModels;
using Nasab.Domain.ValueObjects;
using System;

namespace Nasab.Domain
{
    public class PeopleNasab : AggregateRoot<PeopleNasab, PeopleNasabReadModel>
    {
        public PeopleNasab(Guid identity, PeopleId person, PersonFaithStage faithStage, PeopleId father, Guid kabilahId, PeopleId mother = null, bool died = false) : base(identity)
        {
            Person = person;
            Father = father;
            KabilahId = kabilahId;
            NasabPath = string.Empty;
            FaithStage = faithStage;
            Died = died;

            ReadModel = new PeopleNasabReadModel(Identity) {
                PersonId = Person.Value,
                FatherId = Father.Value,
                KabilahId = KabilahId.ToString(),
                NasabPath = NasabPath,
                FaithStage = FaithStage,
                Died = Died
            };

            if (mother == null)
                ReadModel.AddDomainEvent(new OnNasabAddedWithoutMother(Guid.Parse(Person.Value), Guid.Parse(Father.Value), kabilah: KabilahId));
            else
                ReadModel.AddDomainEvent(new OnNasabAddedWithMother(Guid.Parse(Person.Value), Guid.Parse(Father.Value), Guid.Parse(mother.Value), kabilah: KabilahId));

        }

        public PeopleNasab(PeopleNasabReadModel readModel) : base(readModel)
        {
        }

        public PeopleId Person { get; }

        public PeopleId Father { get; }
        public Guid KabilahId { get; }
        public string NasabPath { get; }

        public PersonFaithStage FaithStage { get; }

        public bool Died { get; }

        protected override PeopleNasab GetEntity()
        {
            return this;
        }
    }
}
