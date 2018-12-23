using Infrastructure.Domain;
using Nasab.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Nasab.Domain.Entities
{
    public class Wedding : EntityBase<Wedding>
    {
        public Wedding(Guid identity, PeopleId father, Guid kabilahId, PeopleId mother = null) : base(identity)
        {
            KabilahID = kabilahId;

            Father = father;
            Mother = mother;

            Divorced = false;

            Chidren = new List<PeopleId>().AsReadOnly();
        }

        public IReadOnlyCollection<PeopleId> Chidren { get; }

        public Guid KabilahID { get; }

        public PeopleId Father { get; }

        public PeopleId Mother { get; }

        public bool Divorced { get; }

        protected override Wedding GetEntity()
        {
            return this;
        }
    }
}
