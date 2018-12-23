// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Barebone.ViewModels.Barebone;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Barebone.Controllers
{
    public class BareboneController : ControllerBase
    {
        public BareboneController(IServiceProvider provider) : base(provider)
        {
        }

        public ActionResult Index()
        {
            return this.View(new IndexViewModelFactory().Create());
        }
    }
}