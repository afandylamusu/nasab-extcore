using System;
using System.Collections.Generic;
using System.Text;
using Contacts.ViewModels.Contacts;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers
{
    public class ContactsController : Barebone.Controllers.ControllerBase
    {
        public ContactsController(IStorage storage) : base(storage)
        {
        }

        public ActionResult Index()
        {
            return this.View(new IndexViewModelFactory().Create(this.Storage));
        }
    }
}
