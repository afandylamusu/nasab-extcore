using Contacts.Domain.ReadModels;
using Infrastructure.Domain;
using System;

namespace Contacts.Domain
{
    public class People : AggregateRoot<People, PeopleReadModel>
    {
        public People(Guid identity) : base(identity)
        {
        }

        public People(PeopleReadModel readModel) : base(readModel)
        {
        }

        protected override People GetEntity()
        {
            return this;
        }
    }
}
