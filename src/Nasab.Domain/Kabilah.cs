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
    }
}
