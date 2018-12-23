using Contacts.Domain;
using Contacts.Domain.Commands;
using ExtCore.Data.Abstractions;
using Infrastructure.Domain.Commands;
using MediatR;
using Nasab.Domain.Repositories;
using Nasab.Domain.ValueObjects;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Nasab.Domain.Commands
{
    public class AddNasabByAdminCommandHandler : ICommandHandler<AddNasabByAdminCommand, PeopleNasab>
    {
        private readonly IMediator _commandBus;
        private readonly IPeopleNasabRepository _peopleNasabRepository;
        private readonly IStorage _storage;

        public AddNasabByAdminCommandHandler(IMediator commandBus, IStorage storage)
        {
            _commandBus = commandBus;
            _peopleNasabRepository = storage.GetRepository<IPeopleNasabRepository>();

            _storage = storage;
        }

        public async Task<PeopleNasab> Handle(AddNasabByAdminCommand request, CancellationToken cancellationToken)
        {
            Contact contact = await _commandBus.Send(new AddPeopleCommand { ContactID = request.PersonId, Names = request.PersonNames }, cancellationToken);

            var nasab = new PeopleNasab(Guid.NewGuid(), new PeopleId(contact.Identity.ToString()), PersonFaithStage.Ordinary, new PeopleId(request.FatherId));

            await _peopleNasabRepository.Update(nasab);

            _storage.Save();

            return nasab;
        }
    }
}