using Contacts.Domain.ReadModels;
using Infrastructure.Domain;
using System;

namespace Contacts.Domain
{
    public class Contact : AggregateRoot<Contact, ContactReadModel>
    {
        public string[] Names { get; }

        public Contact(Guid identity, string[] names) : base(identity)
        {
            Names = names;

            ReadModel = new ContactReadModel(Identity) {
                NamesJson = Names.Serialize()
            };
        }

        public Contact(ContactReadModel readModel) : base(readModel)
        {
        }


        protected override Contact GetEntity()
        {
            return this;
        }
    }
}
