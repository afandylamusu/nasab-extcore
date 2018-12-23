using Contacts.Domain.ReadModels;
using Infrastructure.Data.EntityFrameworkCore;

namespace Contacts.Domain.Repositories
{
    public class ContactRepository : AggregateRepostory<Contact, ContactReadModel>, IContactRepository
    {
        protected override Contact Map(ContactReadModel readModel)
        {
            return new Contact(readModel);
        }
    }
}
