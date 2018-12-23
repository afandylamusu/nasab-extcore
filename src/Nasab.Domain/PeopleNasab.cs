using Infrastructure.Domain;
using Nasab.Domain.ReadModels;
using Nasab.Domain.ValueObjects;
using System;

namespace Nasab.Domain
{
    public class PeopleNasab : AggregateRoot<PeopleNasab, PeopleNasabReadModel>
    {
        public PeopleNasab(Guid identity, PeopleId person, PersonFaithStage faithStage, PeopleId father) : base(identity)
        {
            Person = person;
            Father = father;
            NasabPath = string.Empty;
            FaithStage = faithStage;

            Died = false;
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
