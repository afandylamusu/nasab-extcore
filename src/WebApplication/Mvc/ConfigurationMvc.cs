﻿using ExtCore.Mvc.Infrastructure.Actions;
using FluentValidation.AspNetCore;
using Infrastructure.Mvc.Filters;
using Manufactures.Domain.Orders.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.Mvc
{
    public class ConfigurationMvc : IAddMvcAction
    {
        public int Priority => 1000;

        public void Execute(IMvcBuilder builder, IServiceProvider sp)
        {
            builder.AddMvcOptions(c =>
            {
                c.Filters.Add<TransactionDbFilter>();

                c.Filters.Add<GlobalExceptionFilter>();
            });

            builder.AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<PlaceOrderCommandValidator>();
            });
        }
    }
}