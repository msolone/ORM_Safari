﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ORM_Safari;

namespace ORM_Safari.Migrations
{
    [DbContext(typeof(SafariVacationContext))]
    [Migration("20180918031414_AddDateTimeColumnToSeenAnimalsTable")]
    partial class AddDateTimeColumnToSeenAnimalsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ORM_Safari.Models.SeenAnimals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountOfTimesSeen");

                    b.Property<DateTime>("LastSeenTime");

                    b.Property<string>("LocationOfLastSeen");

                    b.Property<string>("Species");

                    b.HasKey("Id");

                    b.ToTable("SeenAnimalsTable");
                });
#pragma warning restore 612, 618
        }
    }
}
