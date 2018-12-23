﻿using Infrastructure;
using System.Diagnostics;

namespace Nasab.Admin.Web
{
    public class WorkContext : IWebApiContext
    {
        public WorkContext()
        {
            ApiVersion = FileVersionInfo.GetVersionInfo(typeof(Startup).Assembly.Location).FileVersion;
        }

        public string CurrentUser { get; internal set; }

        public string ApiVersion { get; internal set; }
    }
}