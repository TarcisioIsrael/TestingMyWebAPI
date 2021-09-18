using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using Tomappto.Domain.Aggregates.TomatoAggregate;

namespace Tomappto.Infrastructure.EntityConfigurations
{
    public class TomatoEntityConfiguration : IEntityTypeConfiguration<Tomato>
    {
        public void Configure(EntityTypeBuilder<Tomato> builder)
        {
            builder.ToTable("Tomatoes", TomatoesContext.DefaultSchema);
            builder.HasKey(k => k.Id);
            builder
                .Property(pg => pg.Id)
                .HasColumnName("TomatoId")
                .ValueGeneratedNever()
                .IsRequired();

            builder.HasData(new List<Tomato>() 
            { 
                new Tomato(DateTime.Now,"Person1"),
                new Tomato(DateTime.Now,"Person2"),
                new Tomato(DateTime.Now,"Person3"),
            });

        }
    }
}
