using ExtCore.Data.Abstractions;

namespace Contacts.Controllers
{
    public class ProfileController : Barebone.Controllers.ControllerBase
    {
        public ProfileController(IStorage storage) : base(storage)
        {
        }
    }
}
