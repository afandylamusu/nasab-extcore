using Contacts.Domain.Repositories;
using ExtCore.Data.Abstractions;
using Infrastructure.Domain.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Contacts.Domain.Commands
{
    public class AddPeopleCommandHandler : ICommandHandler<AddPeopleCommand, Contact>
    {
        private readonly IContactRepository _contactRepo;
        private readonly IStorage _storage;

        public AddPeopleCommandHandler(IStorage storage)
        {
            _contactRepo = storage.GetRepository<IContactRepository>();

            _storage = storage;
        }

        public async Task<Contact> Handle(AddPeopleCommand request, CancellationToken cancellationToken)
        {
            var contact = new Contact(request.ContactId, request.Names);

            await _contactRepo.Update(contact);

            return contact;
        }
    }
}
