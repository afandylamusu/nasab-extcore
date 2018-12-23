using Infrastructure.Domain.Repositories;
using Nasab.Domain.ReadModels;

namespace Nasab.Domain.Repositories
{
    public interface IPeopleNasabRepository : IAggregateRepository<PeopleNasab, PeopleNasabReadModel>
    {
    }
}
