using Microsoft.AspNetCore.Mvc;
using System;

namespace Nasab.Controllers
{
    public class NasabController : Barebone.Controllers.ControllerBase
    {
        public NasabController(IServiceProvider provider) : base(provider)
        {
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}
