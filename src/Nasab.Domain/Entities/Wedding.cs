using Infrastructure.Domain;
using Nasab.Domain.ReadModels;
using Nasab.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Nasab.Domain.Entities
{
    public class Wedding : EntityBase<Wedding>
    {
        public Wedding(Guid identity, PersonId father, PersonId mother, Guid kabilahId) : base(identity)
        {
            KabilahID = kabilahId;

            Father = father;
            Mother = mother;

            Divorced = false;

            Chidren = new List<PersonId>().AsReadOnly();
        }

        public IReadOnlyCollection<PersonId> Chidren { get; }
        public Guid KabilahID { get; }
        public PersonId Father { get; }
        public PersonId Mother { get; }
        public bool Divorced { get; }

        protected override Wedding GetEntity()
        {
            return this;
        }
    }
}
