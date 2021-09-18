﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tomappto.Infrastructure;

namespace Tomappto.Infrastructure.Migrations
{
    [DbContext(typeof(TomatoesContext))]
    [Migration("20210918180809_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tomappto.Domain.Aggregates.TomatoAggregate.Tomato", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TomatoId");

                    b.Property<string>("PickedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PickedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tomatoes", "Tomappto");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8503ddab-6ea8-4b21-ae9d-e7b500490be1"),
                            PickedBy = "Person1",
                            PickedOn = new DateTime(2021, 9, 18, 11, 8, 9, 155, DateTimeKind.Local).AddTicks(9086)
                        },
                        new
                        {
                            Id = new Guid("99ac725b-eb7c-4bd8-8070-35be26938531"),
                            PickedBy = "Person2",
                            PickedOn = new DateTime(2021, 9, 18, 11, 8, 9, 160, DateTimeKind.Local).AddTicks(9737)
                        },
                        new
                        {
                            Id = new Guid("c500614b-30df-4e42-83b7-0b605b971499"),
                            PickedBy = "Person3",
                            PickedOn = new DateTime(2021, 9, 18, 11, 8, 9, 160, DateTimeKind.Local).AddTicks(9816)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
