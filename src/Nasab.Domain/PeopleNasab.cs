using Infrastructure.Domain;
using Nasab.Domain.Events;
using Nasab.Domain.ReadModels;
using Nasab.Domain.ValueObjects;
using System;

namespace Nasab.Domain
{
    public class PeopleNasab : AggregateRoot<PeopleNasab, PeopleNasabReadModel>
    {
        public PeopleNasab(Guid identity, PeopleId person, PersonFaithStage faithStage, PeopleId father, bool died = false) : base(identity)
        {
            Person = person;
            Father = father;
            NasabPath = string.Empty;
            FaithStage = faithStage;
            Died = died;

            ReadModel = new PeopleNasabReadModel(Identity) {
                PersonId = Person.Value,
                FatherId = Father.Value,
                NasabPath = NasabPath,
                FaithStage = FaithStage,
                Died = Died
            };

            ReadModel.AddDomainEvent(new OnPeopleNasabAdded(Identity));
        }

        public PeopleNasab(PeopleNasabReadModel readModel) : base(readModel)
        {
        }

        public PeopleId Person { get; }

        public PeopleId Father { get; }

        public string NasabPath { get; }

        public PersonFaithStage FaithStage { get; }

        public bool Died { get; }

        protected override PeopleNasab GetEntity()
        {
            return this;
        }
    }
}
