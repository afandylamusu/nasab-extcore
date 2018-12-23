using Contacts.ViewModels.Contacts;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Contacts.Controllers
{
    public class ContactsController : Barebone.Controllers.ControllerBase
    {
        public ContactsController(IServiceProvider provider) : base(provider)
        {
        }

        public ActionResult Index()
        {
            return this.View(new IndexViewModelFactory().Create(this.Storage));
        }
    }
}
