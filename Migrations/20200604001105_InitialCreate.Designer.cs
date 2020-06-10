﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using beta_isa_0.Context;

namespace beta_isa_0.Migrations
{
    [DbContext(typeof(AlumnoContext))]
    [Migration("20200604001105_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("beta_isa_0.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NroDocumento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Alumnos");
                });
#pragma warning restore 612, 618
        }
    }
}
