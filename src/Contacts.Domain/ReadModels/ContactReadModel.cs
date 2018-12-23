using Infrastructure.Domain.ReadModels;
using System;

namespace Contacts.Domain.ReadModels
{
    public class ContactReadModel : ReadModelBase
    {
        public ContactReadModel(Guid identity) : base(identity)
        {
        }
    }
}
