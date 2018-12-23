using Contacts.Domain.ReadModels;
using Infrastructure.Data.EntityFrameworkCore;

namespace Contacts.Domain.Repositories
{
    public class PeopleRepository : AggregateRepostory<People, PeopleReadModel>, IPeopleRepository
    {
        protected override People Map(PeopleReadModel readModel)
        {
            return new People(readModel);
        }
    }
}
