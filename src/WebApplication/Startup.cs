﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Nasab.Admin.Web.Schedulers;
using ExtCore.Data.EntityFramework;
using ExtCore.WebApplication.Extensions;
using FluentScheduler;
using Infrastructure.External.DanLirisClient.CoreMicroservice;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace Nasab.Admin.Web
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        private readonly string extensionsPath;

        public Startup(IHostingEnvironment hostingEnvironment, IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            this.configuration = configuration;
            this.extensionsPath = hostingEnvironment.ContentRootPath + this.configuration["Extensions:Path"];

            loggerFactory.AddConsole();
            loggerFactory.AddDebug();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<StorageContextOptions>(options =>
                {
                    options.ConnectionString = this.configuration.GetConnectionString("Default");
                    options.MigrationsAssembly = typeof(DesignTimeStorageContextFactory).GetTypeInfo().Assembly.FullName;
                }
            );

            services.Configure<MasterDataSettings>(options =>
            {
                options.Endpoint = this.configuration.GetSection("DanLiris").GetValue<string>("MasterDataEndpoint");
                options.TokenEndpoint = this.configuration.GetSection("DanLiris").GetValue<string>("TokenEndpoint");
            });

            services.AddExtCore(this.extensionsPath, includingSubpaths: true);

            services.AddMediatR();

            DesignTimeStorageContextFactory.Initialize(services.BuildServiceProvider());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Weaving API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            app.UseExtCore();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

            JobManager.Initialize(new DefaultScheduleRegistry());
        }
    }
}