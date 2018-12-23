using Infrastructure.Domain;
using Nasab.Domain.ReadModels;
using Nasab.Domain.ValueObjects;
using System;

namespace Nasab.Domain
{
    public class PeopleNasab : AggregateRoot<PeopleNasab, PeopleNasabReadModel>
    {
        public PeopleNasab(Guid identity, PersonId person, PersonFaithStage faithStage) : base(identity)
        {
            Person = person;
            NasabPath = string.Empty;
            FaithStage = faithStage;

            Died = false;
        }

        public PersonId Person { get; }

        public string NasabPath { get; }

        public PersonFaithStage FaithStage { get; }

        public bool Died { get; }

        protected override PeopleNasab GetEntity()
        {
            return this;
        }
    }
}
