﻿using Contacts.Domain.ReadModels;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;

namespace Contacts.Data.EntityFrameworkCore
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder builder)
        {
            builder.Entity<ContactReadModel>(etb =>
                {
                    etb.ToTable("Contacts");
                    etb.HasKey(e => e.Identity);

                    etb.ApplyAuditTrail();
                    etb.ApplySoftDelete();

                    etb.Property(p => p.NamesJson).HasMaxLength(256).IsRequired();
                }
            );
        }
    }
}
