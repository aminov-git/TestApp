﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonneCrud.DbContexts;

#nullable disable

namespace PersonneCrud.Migrations
{
    [DbContext(typeof(PersonneContext))]
    [Migration("20230622093119_PersonneDBFirstMigration")]
    partial class PersonneDBFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.18");

            modelBuilder.Entity("PersonneCrud.Model.Personne", b =>
                {
                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Nom");

                    b.ToTable("personnes");
                });
#pragma warning restore 612, 618
        }
    }
}