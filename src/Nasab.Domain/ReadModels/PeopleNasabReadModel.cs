using Infrastructure.Domain.ReadModels;
using System;

namespace Nasab.Domain.ReadModels
{
    public class PeopleNasabReadModel : ReadModelBase
    {
        public PeopleNasabReadModel(Guid identity) : base(identity)
        {
        }

        public string PersonId { get; internal set; }
        public string FatherId { get; internal set; }
        public string NasabPath { get; internal set; }
        public PersonFaithStage FaithStage { get; internal set; }
        public bool Died { get; internal set; }
        public string KabilahId { get; internal set; }
    }
}
