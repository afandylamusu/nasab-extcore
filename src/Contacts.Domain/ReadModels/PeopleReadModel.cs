using Infrastructure.Domain.ReadModels;
using System;

namespace Contacts.Domain.ReadModels
{
    public class PeopleReadModel : ReadModelBase
    {
        public PeopleReadModel(Guid identity) : base(identity)
        {
        }
    }
}
