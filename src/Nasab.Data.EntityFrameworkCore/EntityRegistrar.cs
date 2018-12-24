using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Nasab.Domain.ReadModels;
using System;

namespace Nasab.Data.EntityFrameworkCore
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder builder)
        {
            builder.Entity<PeopleNasabReadModel>(etb =>
                {
                    etb.ToTable("Nasabs");
                    etb.HasKey(e => e.Identity);

                    etb.ApplyAuditTrail();
                    etb.ApplySoftDelete();

                    etb.Property(p => p.NasabPath).HasMaxLength(500);
                }
            );
        }
    }
}
