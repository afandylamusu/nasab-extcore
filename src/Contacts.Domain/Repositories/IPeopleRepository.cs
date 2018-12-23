using Contacts.Domain.ReadModels;
using Infrastructure.Domain.Repositories;

namespace Contacts.Domain.Repositories
{
    public interface IPeopleRepository : IAggregateRepository<People, PeopleReadModel>
    {
    }
}
