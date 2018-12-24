using Contacts.Domain;
using Contacts.Domain.Commands;
using Contacts.Domain.Repositories;
using ExtCore.Data.Abstractions;
using Infrastructure.Domain.Commands;
using MediatR;
using Moonlay;
using Nasab.Domain.Repositories;
using Nasab.Domain.ValueObjects;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Nasab.Domain.Commands
{
    public class AddNasabCommandHandler : ICommandHandler<AddNasabCommand, PeopleNasab>
    {
        private readonly IMediator _commandBus;
        private readonly IPeopleNasabRepository _peopleNasabRepo;
        private readonly IContactRepository _contactRepo;
        private readonly IStorage _storage;

        public AddNasabCommandHandler(IMediator commandBus, IStorage storage)
        {
            _commandBus = commandBus;
            _peopleNasabRepo = storage.GetRepository<IPeopleNasabRepository>();
            _contactRepo = storage.GetRepository<IContactRepository>();

            _storage = storage;
        }

        public async Task<PeopleNasab> Handle(AddNasabCommand request, CancellationToken cancellationToken)
        {
            var namesJson = request.PersonNames.Serialize();

            var persons = _contactRepo.Find(o => o.NamesJson == namesJson).ToArray();
            var personIds = persons.Select(o => o.Identity);

            var nasabExists = _peopleNasabRepo.Find(o => personIds.Contains(o.PersonId) && o.FatherId == request.FatherId).FirstOrDefault();

            if (nasabExists != null)
                throw Validator.ErrorValidation((nameof(request.PersonNames), $"{string.Join(" ", request.PersonNames)} Already has nasab"));

            Contact contact = persons.FirstOrDefault() ?? await _commandBus.Send(new AddPeopleCommand { ContactId = request.PersonId, Names = request.PersonNames }, cancellationToken);

            var nasab = new PeopleNasab(Guid.NewGuid(),
                person: new PeopleId(contact.Identity),
                faithStage: PersonFaithStage.Ordinary,
                father: new PeopleId(request.FatherId),
                kabilahId: request.KabilahId);

            await _peopleNasabRepo.Update(nasab);

            return nasab;
        }
    }
}