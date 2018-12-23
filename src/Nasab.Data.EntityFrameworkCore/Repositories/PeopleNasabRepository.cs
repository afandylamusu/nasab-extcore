using Infrastructure.Data.EntityFrameworkCore;
using Nasab.Domain.ReadModels;

namespace Nasab.Domain.Repositories
{
    public class PeopleNasabRepository : AggregateRepostory<PeopleNasab, PeopleNasabReadModel>, IPeopleNasabRepository
    {
        protected override PeopleNasab Map(PeopleNasabReadModel readModel)
        {
            return new PeopleNasab(readModel);
        }
    }
}
