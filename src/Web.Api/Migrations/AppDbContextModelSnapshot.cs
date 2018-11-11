﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Api.Infrastructure.Data;

namespace Web.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Web.Api.Core.Domain.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("FirstName");

                    b.Property<int>("Height");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("Modified");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new { Id = 1, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Sidney", Height = 124, LastName = "Crosby", Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
