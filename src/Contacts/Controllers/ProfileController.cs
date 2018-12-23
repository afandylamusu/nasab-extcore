using ExtCore.Data.Abstractions;
using System;

namespace Contacts.Controllers
{
    public class ProfileController : Barebone.Controllers.ControllerBase
    {
        public ProfileController(IServiceProvider provider) : base(provider)
        {
        }
    }
}
