using Infrastructure.Domain.Repositories;
using Nasab.Domain.ReadModels;

namespace Nasab.Domain.Repositories
{
    public interface IKabilahRepository : IAggregateRepository<Kabilah, KabilahReadModel>
    {
    }
}
