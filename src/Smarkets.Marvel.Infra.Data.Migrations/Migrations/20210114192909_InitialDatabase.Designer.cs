﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Smarkets.Marvel.Infra.Data.Context;

namespace Smarkets.Marvel.Infra.Data.Migrations.Migrations
{
    [DbContext(typeof(SmarketsMarvelContext))]
    [Migration("20210114192909_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Smarkets.Marvel.Domain.Entities.SearchHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SearchDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SearchTerm")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("SearchHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
