using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Nasab.Controllers
{
    public class NasabController : Barebone.Controllers.ControllerBase
    {
        public NasabController(IStorage storage) : base(storage)
        {
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}
