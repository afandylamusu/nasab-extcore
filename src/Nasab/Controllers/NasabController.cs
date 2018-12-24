using Microsoft.AspNetCore.Mvc;
using Nasab.Domain.Commands;
using Nasab.ViewModels.Nasab;
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

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(CreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                model.Map(out AddNasabCommand command);

                var result = Mediator.Send(command).Result;

                this.Storage.Save();

                return this.RedirectToAction("index");
            }

            return this.View();
        }
    }
}